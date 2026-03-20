#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayer<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnPlayer : BmSDK.BmGame.RPawnPlayerSpeech, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayer() { }

    /// <summary>
    /// Constructs a new RPawnPlayer
    /// </summary>
    public RPawnPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayer(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4396); }
    }

    /// <summary>
    /// ObjectProperty: V2AttackCoord
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Base V2AttackCoord
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Base>(Ptr + 4404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4404); }
    }

    /// <summary>
    /// ObjectProperty: MostRecentThugToSeePlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController MostRecentThugToSeePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 4412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4412); }
    }

    /// <summary>
    /// ObjectProperty: ZipKickAnimSetOverride
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ZipKickAnimSetOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4420); }
    }

    /// <summary>
    /// ObjectProperty: XrayMaskMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMaskMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 4428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4428); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4436); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface ThermalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// ObjectProperty: XRayBoneMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayBoneMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4460); }
    }

    /// <summary>
    /// ObjectProperty: XRayBoneMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 4468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4468); }
    }

    /// <summary>
    /// ObjectProperty: XRayGutsMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayGutsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }

    /// <summary>
    /// ObjectProperty: XRayGutsMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayGutsMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4484); }
    }

    /// <summary>
    /// ObjectProperty: GrappleLoopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GrappleLoopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4492); }
    }

    /// <summary>
    /// ObjectProperty: GrappleGun
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun GrappleGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonGun
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonGun HarpoonGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonGun>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }

    /// <summary>
    /// ObjectProperty: ResonatorTuner
    /// </summary>
    public unsafe BmSDK.BmGame.RResonatorTuner ResonatorTuner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RResonatorTuner>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncher
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncher LineLauncher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncher>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }

    /// <summary>
    /// ObjectProperty: Batarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang Batarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// ObjectProperty: GooSpray
    /// </summary>
    public unsafe BmSDK.BmGame.RGooSpray GooSpray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGooSpray>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// ObjectProperty: SmokeBomb
    /// </summary>
    public unsafe BmSDK.BmGame.RSmokeBomb SmokeBomb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSmokeBomb>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }

    /// <summary>
    /// ObjectProperty: MagneticBlast
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast MagneticBlast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }

    /// <summary>
    /// ObjectProperty: FreezeSpray
    /// </summary>
    public unsafe BmSDK.BmGame.RFreezeSpray FreezeSpray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFreezeSpray>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }

    /// <summary>
    /// ObjectProperty: FreezeClusterGrenade
    /// </summary>
    public unsafe BmSDK.BmGame.RFreezeClusterGrenade FreezeClusterGrenade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFreezeClusterGrenade>(Ptr + 4572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4572); }
    }

    /// <summary>
    /// ObjectProperty: JammerGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget JammerGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// ObjectProperty: Caltrops
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileGadgetBase Caltrops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileGadgetBase>(Ptr + 4588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4588); }
    }

    /// <summary>
    /// ObjectProperty: Whip
    /// </summary>
    public unsafe BmSDK.BmGame.RWhipBase Whip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWhipBase>(Ptr + 4596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4596); }
    }

    /// <summary>
    /// ObjectProperty: Staff
    /// </summary>
    public unsafe BmSDK.BmGame.RStaffBase Staff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStaffBase>(Ptr + 4604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4604); }
    }

    /// <summary>
    /// ObjectProperty: Sticks
    /// </summary>
    public unsafe BmSDK.BmGame.RSticksGadgetBase Sticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSticksGadgetBase>(Ptr + 4612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4612); }
    }

    /// <summary>
    /// ObjectProperty: BlowDart
    /// </summary>
    public unsafe BmSDK.BmGame.RBlowDartBase BlowDart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBlowDartBase>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// ObjectProperty: RCBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang RCBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// ObjectProperty: SonicBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang SonicBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 4636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4636); }
    }

    /// <summary>
    /// ObjectProperty: RHD
    /// </summary>
    public unsafe BmSDK.BmGame.RRHD RHD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRHD>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }

    /// <summary>
    /// ObjectProperty: DisruptorSniper
    /// </summary>
    public unsafe BmSDK.BmGame.RDisruptorSniper DisruptorSniper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDisruptorSniper>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }

    /// <summary>
    /// ObjectProperty: VoiceSynthesiser
    /// </summary>
    public unsafe BmSDK.BmGame.RVoiceSynthesiser VoiceSynthesiser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVoiceSynthesiser>(Ptr + 4660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4660); }
    }

    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4700); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }

    /// <summary>
    /// ObjectProperty: RailingLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4716); }
    }

    /// <summary>
    /// ObjectProperty: RailingLandWalkMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingLandWalkMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }

    /// <summary>
    /// ObjectProperty: CornerSlipMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerSlipMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4732); }
    }

    /// <summary>
    /// ObjectProperty: CornerSlipCrouchMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerSlipCrouchMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }

    /// <summary>
    /// ObjectProperty: CornerTurnMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerTurnMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4748); }
    }

    /// <summary>
    /// ObjectProperty: RoundCornerMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RoundCornerMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }

    /// <summary>
    /// ObjectProperty: MoveIntoCornerMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig MoveIntoCornerMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4764); }
    }

    /// <summary>
    /// ObjectProperty: PhotoScanner
    /// </summary>
    public unsafe BmSDK.BmGame.RPhotoScanner PhotoScanner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhotoScanner>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsGrabber
    /// </summary>
    public unsafe BmSDK.BmGame.RPhysicsGrabber PhysicsGrabber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhysicsGrabber>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }

    /// <summary>
    /// ObjectProperty: NavMeshInspector
    /// </summary>
    public unsafe BmSDK.BmGame.RNavMeshInspector NavMeshInspector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavMeshInspector>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }

    /// <summary>
    /// ObjectProperty: MagicSmasher
    /// </summary>
    public unsafe BmSDK.BmGame.RMagicSmasher MagicSmasher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagicSmasher>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// ObjectProperty: MagicGunStartle
    /// </summary>
    public unsafe BmSDK.BmGame.RMagicGunStartle MagicGunStartle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagicGunStartle>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// ObjectProperty: ExplosionEffect
    /// </summary>
    public unsafe BmSDK.BmGame.RExplosionPostProcess ExplosionEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RExplosionPostProcess>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// ObjectProperty: LastGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget LastGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// ObjectProperty: PrimaryFearTakedownTargetMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface PrimaryFearTakedownTargetMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ObjectProperty: SecondaryFearTakedownTargetMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface SecondaryFearTakedownTargetMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// ObjectProperty: ActiveTunnelFunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel ActiveTunnelFunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }

    /// <summary>
    /// ObjectProperty: NearestTunnelFunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel NearestTunnelFunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }

    /// <summary>
    /// ObjectProperty: LastTakedownActorInstance
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastTakedownActorInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }

    /// <summary>
    /// ObjectProperty: CurrentPylonForTakedownCheck
    /// </summary>
    public unsafe BmSDK.Engine.Pylon CurrentPylonForTakedownCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 4868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4868); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDeathLine
    /// </summary>
    public unsafe BmSDK.Engine.AkEmoteType PlayerDeathLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEmoteType>(Ptr + 4876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4876); }
    }

    /// <summary>
    /// ObjectProperty: GrateExcluder
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance GrateExcluder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 4884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4884); }
    }

    /// <summary>
    /// ObjectProperty: LegGrateExcluder
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance LegGrateExcluder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 4892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4892); }
    }

    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4900); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4908); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4916); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4924); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4932); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4940); }
    }

    /// <summary>
    /// ObjectProperty: FallingTargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor FallingTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4948); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileCallMarkerTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BatmobileCallMarkerTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4956); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileCallMarkerInvalidTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BatmobileCallMarkerInvalidTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4964); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileCallMarkerSuccessTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BatmobileCallMarkerSuccessTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4972); }
    }

    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 5012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5012); }
    }

    /// <summary>
    /// ObjectProperty: LastWirePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_RopeBase LastWirePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_RopeBase>(Ptr + 5020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5020); }
    }

    /// <summary>
    /// ObjectProperty: CurrentCeilingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume CurrentCeilingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 5028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5028); }
    }

    /// <summary>
    /// ObjectProperty: GrateToCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateCWFlipBase GrateToCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateCWFlipBase>(Ptr + 5036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5036); }
    }

    /// <summary>
    /// ObjectProperty: GrateFromCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateCWFlipBase GrateFromCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateCWFlipBase>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }

    /// <summary>
    /// ObjectProperty: ActiveGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateCWFlipBase ActiveGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateCWFlipBase>(Ptr + 5052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5052); }
    }

    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5060); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5076); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5116); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5124); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5148); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5164); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5172); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5180); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5188); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5196); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5204); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5212); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5220); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5228); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5236); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5260); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5268); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5276); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5284); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5292); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5300); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickOverridePS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlideKickOverridePS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5316); }
    }

    /// <summary>
    /// ObjectProperty: SuperGlideAttackFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SuperGlideAttackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5324); }
    }

    /// <summary>
    /// ObjectProperty: FearTakedownHighlightBeam
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FearTakedownHighlightBeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5332); }
    }

    /// <summary>
    /// ObjectProperty: SuperGlideAttackMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SuperGlideAttackMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5340); }
    }

    /// <summary>
    /// ObjectProperty: TraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController TraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }

    /// <summary>
    /// ObjectProperty: StealthMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController StealthMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }

    /// <summary>
    /// ObjectProperty: RunTraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController RunTraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }

    /// <summary>
    /// ObjectProperty: StealthTraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController StealthTraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }

    /// <summary>
    /// ObjectProperty: WalkingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController WalkingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5380); }
    }

    /// <summary>
    /// ObjectProperty: JumpOffRailingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController JumpOffRailingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5388); }
    }

    /// <summary>
    /// ObjectProperty: FallingSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController FallingSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5396); }
    }

    /// <summary>
    /// ObjectProperty: FallingClimbSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController FallingClimbSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5404); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CapeGlideSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5412); }
    }

    /// <summary>
    /// ObjectProperty: HardCapeGlideSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController HardCapeGlideSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5420); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromLedgeMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromLedgeMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5428); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromDangleMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromDangleMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5436); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromLadderMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromLadderMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }

    /// <summary>
    /// ObjectProperty: LedgeMovesLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController LedgeMovesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5452); }
    }

    /// <summary>
    /// ObjectProperty: LedgeMovesRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController LedgeMovesRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5460); }
    }

    /// <summary>
    /// ObjectProperty: DangleMovesLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController DangleMovesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }

    /// <summary>
    /// ObjectProperty: DangleMovesRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController DangleMovesRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }

    /// <summary>
    /// ObjectProperty: JumpStraightOffRailingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController JumpStraightOffRailingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5484); }
    }

    /// <summary>
    /// ObjectProperty: ClimbDownMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbDownMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }

    /// <summary>
    /// ObjectProperty: CoverMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CoverMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5500); }
    }

    /// <summary>
    /// ObjectProperty: TakedownClimbDownMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController TakedownClimbDownMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }

    /// <summary>
    /// ObjectProperty: ClimbDownFromRailingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbDownFromRailingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayShotMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DualPlayShotMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }

    /// <summary>
    /// ObjectProperty: CustomisableFallingGrabLedgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentSpecialMoveWrapperFalling CustomisableFallingGrabLedgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentSpecialMoveWrapperFalling>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang128
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang128
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5556); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang128Dangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang128Dangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5564); }
    }

    /// <summary>
    /// ObjectProperty: StepOffRailing128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StepOffRailing128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }

    /// <summary>
    /// ObjectProperty: DropOffWireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DropOffWireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5588); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickHorizontalWindowMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideKickHorizontalWindowMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5596); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickVerticalWindowMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideKickVerticalWindowMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5604); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }

    /// <summary>
    /// ObjectProperty: DiveOffBuildingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOffBuildingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5620); }
    }

    /// <summary>
    /// ObjectProperty: LastChanceJumpMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LastChanceJumpMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }

    /// <summary>
    /// ObjectProperty: LowGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LowGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5636); }
    }

    /// <summary>
    /// ObjectProperty: ShortGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShortGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5644); }
    }

    /// <summary>
    /// ObjectProperty: ExitCoverLeftMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ExitCoverLeftMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }

    /// <summary>
    /// ObjectProperty: ExitCoverRightMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ExitCoverRightMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }

    /// <summary>
    /// ObjectProperty: SlideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SlideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5676); }
    }

    /// <summary>
    /// ObjectProperty: DiveOverRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOverRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// ObjectProperty: DiveOverRailingToFallMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOverRailingToFallMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5692); }
    }

    /// <summary>
    /// ObjectProperty: RunStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RunStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5700); }
    }

    /// <summary>
    /// ObjectProperty: WalkStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WalkStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5708); }
    }

    /// <summary>
    /// ObjectProperty: StealthStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StealthStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5716); }
    }

    /// <summary>
    /// ObjectProperty: SlideStopAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SlideStopAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5724); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GlideBoostSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5732); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GlideBoostSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 5740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5740); }
    }

    /// <summary>
    /// ObjectProperty: CapeOpenSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName CapeOpenSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 5748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5748); }
    }

    /// <summary>
    /// ObjectProperty: ZappedSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZappedSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5756); }
    }

    /// <summary>
    /// ObjectProperty: UnderWaterVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RWaterRescueVolumeBase UnderWaterVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWaterRescueVolumeBase>(Ptr + 5764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5764); }
    }

    /// <summary>
    /// ObjectProperty: UnderWaterEmitter
    /// </summary>
    public unsafe BmSDK.Engine.REmitter UnderWaterEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }

    /// <summary>
    /// ObjectProperty: GlideWaterWakeEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlideWaterWakeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }

    /// <summary>
    /// ObjectProperty: GrappleWaterWakeEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GrappleWaterWakeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5788); }
    }

    /// <summary>
    /// ObjectProperty: WaterSplashEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WaterSplashEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5796); }
    }

    /// <summary>
    /// ObjectProperty: UnderFearGasEmitter
    /// </summary>
    public unsafe BmSDK.Engine.REmitter UnderFearGasEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 5804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5804); }
    }

    /// <summary>
    /// ObjectProperty: GlideFearGasWakeEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlideFearGasWakeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }

    /// <summary>
    /// ObjectProperty: FearGasSplashEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FearGasSplashEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }

    /// <summary>
    /// ObjectProperty: SlippedCorner
    /// </summary>
    public unsafe BmSDK.Engine.Actor SlippedCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 5828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5828); }
    }

    /// <summary>
    /// ObjectProperty: FallLoopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FallLoopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// ObjectProperty: FootStepNotify
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_Footstep FootStepNotify
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_Footstep>(Ptr + 5844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5844); }
    }

    /// <summary>
    /// ObjectProperty: ChaseVehicleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle ChaseVehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 5852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5852); }
    }

    /// <summary>
    /// ObjectProperty: TestVehicleScenario
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleScenario TestVehicleScenario
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleScenario>(Ptr + 5860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5860); }
    }

    /// <summary>
    /// ObjectProperty: lastGlideKickVictim
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat lastGlideKickVictim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 5868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5868); }
    }

    /// <summary>
    /// ObjectProperty: lastDropAttackVictim
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat lastDropAttackVictim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 5876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5876); }
    }

    /// <summary>
    /// ObjectProperty: ChuteCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RChuteCamera ChuteCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChuteCamera>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// ObjectProperty: CharData
    /// </summary>
    public unsafe BmSDK.BmGame.RAddContentPlayerCharacter CharData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacter>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }

    /// <summary>
    /// ObjectProperty: LastCurrentHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LastCurrentHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 5900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5900); }
    }

    /// <summary>
    /// ObjectProperty: FallingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FallingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5908); }
    }

    /// <summary>
    /// ObjectProperty: RiddlerCharData
    /// </summary>
    public unsafe BmSDK.BmGame.RAddContentPlayerCharacter RiddlerCharData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacter>(Ptr + 5916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5916); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStealthTakeDown
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage CurrentStealthTakeDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 5924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5924); }
    }

    /// <summary>
    /// ObjectProperty: DoubleTeamVantageEscapeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DoubleTeamVantageEscapeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5932); }
    }

    /// <summary>
    /// ObjectProperty: BackupCharData
    /// </summary>
    public unsafe BmSDK.BmGame.RAddContentPlayerCharacter BackupCharData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacter>(Ptr + 5940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5940); }
    }

    /// <summary>
    /// ObjectProperty: SharedBotController
    /// </summary>
    public unsafe BmSDK.Engine.Controller SharedBotController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(Ptr + 5948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5948); }
    }

    /// <summary>
    /// ObjectProperty: LastCornerPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarkerBase LastCornerPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarkerBase>(Ptr + 5956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5956); }
    }

    /// <summary>
    /// ObjectProperty: RealCorner
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarkerBase RealCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarkerBase>(Ptr + 5964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5964); }
    }

    /// <summary>
    /// ObjectProperty: ObstacleRoads
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork ObstacleRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 5972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5972); }
    }

    /// <summary>
    /// ObjectProperty: DualPlayPredatorLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPredatorLine_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 5980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5980); }
    }
    /// <summary>
    /// ObjectProperty: DualPlayPredatorLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPredatorLine_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 5988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5988); }
    }
    /// <summary>
    /// ObjectProperty: DualPlayPredatorLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPredatorLine_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 5996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5996); }
    }
    /// <summary>
    /// ObjectProperty: DualPlayPredatorLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPredatorLine_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }
    /// <summary>
    /// ObjectProperty: DualPlayPredatorLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPredatorLine_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 6012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6012); }
    }
    /// <summary>
    /// ObjectProperty: DualPlayPredatorLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPredatorLine_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 6020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6020); }
    }
    /// <summary>
    /// ObjectProperty: DualPlayPredatorLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPredatorLine_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 6028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6028); }
    }
    /// <summary>
    /// ObjectProperty: DualPlayPredatorLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPredatorLine_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 6036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6036); }
    }
    /// <summary>
    /// ObjectProperty: DualPlayPredatorLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine DualPlayPredatorLine_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 6044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6044); }
    }

    /// <summary>
    /// ObjectProperty: LastSpotterPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastSpotterPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 6052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6052); }
    }

    /// <summary>
    /// ObjectProperty: LastSpotterAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorBase LastSpotterAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorBase>(Ptr + 6060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6060); }
    }

    /// <summary>
    /// ComponentProperty: XrayLightFalloff
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent XrayLightFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 6068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6068); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 6076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6076); }
    }

    /// <summary>
    /// ClassProperty: DestructibleBreakDamageType
    /// </summary>
    public unsafe BmSDK.Class DestructibleBreakDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6084); }
    }

    /// <summary>
    /// ClassProperty: AssistBatarangProjectileClass
    /// </summary>
    public unsafe BmSDK.Class AssistBatarangProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6092); }
    }

    /// <summary>
    /// ClassProperty: GlideKickSmashDamageType
    /// </summary>
    public unsafe BmSDK.Class GlideKickSmashDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6100); }
    }

    /// <summary>
    /// ComponentProperty: HangFromVantageRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent HangFromVantageRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 6108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6108); }
    }

    /// <summary>
    /// ComponentProperty: PlayerIconPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent PlayerIconPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6116); }
    }

    /// <summary>
    /// ClassProperty: ForensicsInvestigatorType
    /// </summary>
    public unsafe BmSDK.Class ForensicsInvestigatorType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6124); }
    }

    /// <summary>
    /// ClassProperty: ForensicsType
    /// </summary>
    public unsafe BmSDK.Class ForensicsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6132); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileCallSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BatmobileCallSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6140); }
    }

    /// <summary>
    /// ComponentProperty: OverrideUnderColl
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent OverrideUnderColl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 6148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6148); }
    }

    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6156); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6164); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6172); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6180); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6188); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6196); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6204); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6212); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6220); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6228); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6236); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6244); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6252); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6260); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6268); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6276); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6284); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6292); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6300); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6308); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6316); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6324); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6332); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6340); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6348); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6356); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6364); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6372); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6380); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6388); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6396); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6404); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6412); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6420); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6428); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6436); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6444); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6452); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6460); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6468); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6476); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6484); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6492); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6500); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6508); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6516); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6524); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6532); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6540); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6548); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6556); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6564); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6572); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6580); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6588); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6596); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6604); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6612); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6620); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6628); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6636); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6644); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6652); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6660); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6668); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6676); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6684); }
    }
    /// <summary>
    /// ClassProperty: FearTakedowns
    /// </summary>
    public unsafe BmSDK.Class FearTakedowns_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6692); }
    }

    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6708); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6716); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6724); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6732); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6740); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6748); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6788); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6804); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6812); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6820); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6828); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6836); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6844); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6852); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6860); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6868); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6876); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6884); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6892); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6900); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6908); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6916); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6924); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6932); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6940); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6948); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6956); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6964); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6972); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6980); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6988); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6996); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7004); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7012); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7020); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7028); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7036); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7044); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7052); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7060); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7068); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7076); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7084); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7092); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7100); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7108); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7116); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7124); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7132); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7140); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7148); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7156); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7164); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7172); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7180); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7188); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7196); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7212); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7220); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7228); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7236); }
    }

    /// <summary>
    /// ClassProperty: AttachedGadget
    /// </summary>
    public unsafe BmSDK.Class AttachedGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 7244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7244); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 7252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7252); }
    }

    /// <summary>
    /// ComponentProperty: GutsMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent GutsMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7260); }
    }

    /// <summary>
    /// ComponentProperty: XraySkeletonMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XraySkeletonMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7268); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskCapeMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskCapeMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7276); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskHeadMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7284); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskBodyMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskBodyMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7292); }
    }

    /// <summary>
    /// StructProperty: LastKnownState
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FAIAwarenessState LastKnownState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FAIAwarenessState>(Ptr + 7300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7300); }
    }

    /// <summary>
    /// BoolProperty: bCheatTrackBMInVent
    /// </summary>
    public unsafe bool bCheatTrackBMInVent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bPlayerIsUnderRedGrate
    /// </summary>
    public unsafe bool bPlayerIsUnderRedGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNavMeshForAvoidance
    /// </summary>
    public unsafe bool bIgnoreNavMeshForAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bWalkingOnWire
    /// </summary>
    public unsafe bool bWalkingOnWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanUseRailings
    /// </summary>
    public unsafe bool bCanUseRailings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanUseSwingKick
    /// </summary>
    public unsafe bool bCanUseSwingKick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanUseVantageGrappling
    /// </summary>
    public unsafe bool bCanUseVantageGrappling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanDoDoubleStealthAttacks
    /// </summary>
    public unsafe bool bCanDoDoubleStealthAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanHangFromVantagePoint
    /// </summary>
    public unsafe bool bCanHangFromVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanInterrogate
    /// </summary>
    public unsafe bool bCanInterrogate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bAllowBackScreen
    /// </summary>
    public unsafe bool bAllowBackScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanRemoveGrates
    /// </summary>
    public unsafe bool bCanRemoveGrates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bIsBrucewayneOrGordon
    /// </summary>
    public unsafe bool bIsBrucewayneOrGordon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bNoCompass
    /// </summary>
    public unsafe bool bNoCompass
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: AudioIsActivePlayer
    /// </summary>
    public unsafe bool AudioIsActivePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: AllowedToOpenWheel
    /// </summary>
    public unsafe bool AllowedToOpenWheel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: DisableTaunts
    /// </summary>
    public unsafe bool DisableTaunts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: CanUseSuperComboGadgets
    /// </summary>
    public unsafe bool CanUseSuperComboGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bReplenishHealth
    /// </summary>
    public unsafe bool bReplenishHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: DeferedVelocitySet
    /// </summary>
    public unsafe bool DeferedVelocitySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: IsGrappling
    /// </summary>
    public unsafe bool IsGrappling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bGliding
    /// </summary>
    public unsafe bool bGliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: IsLineLaunching
    /// </summary>
    public unsafe bool IsLineLaunching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: CanPerchOnVantagePoints
    /// </summary>
    public unsafe bool CanPerchOnVantagePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: IsSlidingUnderVolume
    /// </summary>
    public unsafe bool IsSlidingUnderVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanClimb
    /// </summary>
    public unsafe bool bCanClimb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanCapeGlide
    /// </summary>
    public unsafe bool bCanCapeGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanGrappleBoost
    /// </summary>
    public unsafe bool bCanGrappleBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCanDiveBoost
    /// </summary>
    public unsafe bool bCanDiveBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bCantDropOffLedges
    /// </summary>
    public unsafe bool bCantDropOffLedges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bDisableAllTakedowns
    /// </summary>
    public unsafe bool bDisableAllTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bDisableDoubleTakedownOnInformants
    /// </summary>
    public unsafe bool bDisableDoubleTakedownOnInformants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7428); }
    }

    /// <summary>
    /// BoolProperty: bSimulateLastThugIsInformant
    /// </summary>
    public unsafe bool bSimulateLastThugIsInformant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCharacterUsesRopeLedgeTakedowns
    /// </summary>
    public unsafe bool bCharacterUsesRopeLedgeTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCanPounceOnThugs
    /// </summary>
    public unsafe bool bCanPounceOnThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCanPickPocket
    /// </summary>
    public unsafe bool bCanPickPocket
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bExitStealthOnGlide
    /// </summary>
    public unsafe bool bExitStealthOnGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bThugsHaveCommentedOnGrapple
    /// </summary>
    public unsafe bool bThugsHaveCommentedOnGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: GoingToHangFromVantagePoint
    /// </summary>
    public unsafe bool GoingToHangFromVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: ClimbingBackToVantagePoint
    /// </summary>
    public unsafe bool ClimbingBackToVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: CheckingSwingFloor
    /// </summary>
    public unsafe bool CheckingSwingFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysTrackForDamage
    /// </summary>
    public unsafe bool bAlwaysTrackForDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRailingsForSpecialMove
    /// </summary>
    public unsafe bool bIgnoreRailingsForSpecialMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: GrapplingToVantagePoint
    /// </summary>
    public unsafe bool GrapplingToVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bAllowZoom
    /// </summary>
    public unsafe bool bAllowZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCanUseSurv
    /// </summary>
    public unsafe bool bCanUseSurv
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bEnableGrateExcluders
    /// </summary>
    public unsafe bool bEnableGrateExcluders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bDoingAutonmousMovement
    /// </summary>
    public unsafe bool bDoingAutonmousMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: ShouldCrouchForReplication
    /// </summary>
    public unsafe bool ShouldCrouchForReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bHasJustMovedOntoGargoyle
    /// </summary>
    public unsafe bool bHasJustMovedOntoGargoyle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCanAvoidMines
    /// </summary>
    public unsafe bool bCanAvoidMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: DoingUnderBarrierCheck
    /// </summary>
    public unsafe bool DoingUnderBarrierCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bNoLocalCharacterLight
    /// </summary>
    public unsafe bool bNoLocalCharacterLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCheckNonBlockingCombatPawns
    /// </summary>
    public unsafe bool bCheckNonBlockingCombatPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bPawnCanGrateCrawl
    /// </summary>
    public unsafe bool bPawnCanGrateCrawl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCeilingLedge
    /// </summary>
    public unsafe bool bCanClimbToCeilingLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCeilingFar
    /// </summary>
    public unsafe bool bCanClimbToCeilingFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCatwalkFar
    /// </summary>
    public unsafe bool bCanClimbToCatwalkFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bCanPounceToCeiling
    /// </summary>
    public unsafe bool bCanPounceToCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bJumpedThisFrame
    /// </summary>
    public unsafe bool bJumpedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bAllowGlideKickWithGadget
    /// </summary>
    public unsafe bool bAllowGlideKickWithGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bPlayerIconPSActive
    /// </summary>
    public unsafe bool bPlayerIconPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bDebugObstacleAvoidance
    /// </summary>
    public unsafe bool bDebugObstacleAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bDebugNewCeilingMoves
    /// </summary>
    public unsafe bool bDebugNewCeilingMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7432); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7432); }
    }

    /// <summary>
    /// BoolProperty: bDebugGrateMoves
    /// </summary>
    public unsafe bool bDebugGrateMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bAllowDmgInCineMode
    /// </summary>
    public unsafe bool bAllowDmgInCineMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bJumpFromWhipSwing
    /// </summary>
    public unsafe bool bJumpFromWhipSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bAddedDefaultInventoryAfterInit
    /// </summary>
    public unsafe bool bAddedDefaultInventoryAfterInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceCriticalLand
    /// </summary>
    public unsafe bool bDebugForceCriticalLand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bDebugShowLandRollCheck
    /// </summary>
    public unsafe bool bDebugShowLandRollCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bSilentRunning
    /// </summary>
    public unsafe bool bSilentRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bNeedsWaterWake
    /// </summary>
    public unsafe bool bNeedsWaterWake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bUnderWater
    /// </summary>
    public unsafe bool bUnderWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bGrappleWake
    /// </summary>
    public unsafe bool bGrappleWake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bGrappleWakeEmitter
    /// </summary>
    public unsafe bool bGrappleWakeEmitter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: DelayUnderWaterCheck
    /// </summary>
    public unsafe bool DelayUnderWaterCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bUnderFearGas
    /// </summary>
    public unsafe bool bUnderFearGas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bNeedsFearGasWake
    /// </summary>
    public unsafe bool bNeedsFearGasWake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bOceanExistsAtPlayerLocation
    /// </summary>
    public unsafe bool bOceanExistsAtPlayerLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bInvalidateAllOceanChecksUntilOceanNoLongerExistsAtPlayerLocation
    /// </summary>
    public unsafe bool bInvalidateAllOceanChecksUntilOceanNoLongerExistsAtPlayerLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bDebugInterrogationDetection
    /// </summary>
    public unsafe bool bDebugInterrogationDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bDebugEnvironmentTakedowns
    /// </summary>
    public unsafe bool bDebugEnvironmentTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bDrawRelativeAnimRefPoint
    /// </summary>
    public unsafe bool bDrawRelativeAnimRefPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bSimulateInterrogationMovesNotLoaded
    /// </summary>
    public unsafe bool bSimulateInterrogationMovesNotLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bHealthModifierActive
    /// </summary>
    public unsafe bool bHealthModifierActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: WasDamageProxyActive
    /// </summary>
    public unsafe bool WasDamageProxyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bRiddlerPawn
    /// </summary>
    public unsafe bool bRiddlerPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bLastWantsToCrouch
    /// </summary>
    public unsafe bool bLastWantsToCrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bLastPCForceCrouch
    /// </summary>
    public unsafe bool bLastPCForceCrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bLastHiddenInGrate
    /// </summary>
    public unsafe bool bLastHiddenInGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bDualPlayLockedToGargoyles
    /// </summary>
    public unsafe bool bDualPlayLockedToGargoyles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bBowlingBallMode
    /// </summary>
    public unsafe bool bBowlingBallMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bCanUseGadgetSelect
    /// </summary>
    public unsafe bool bCanUseGadgetSelect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bInvisibleToDrones
    /// </summary>
    public unsafe bool bInvisibleToDrones
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bAccurateShimmyOn
    /// </summary>
    public unsafe bool bAccurateShimmyOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bClimbingToShimmy
    /// </summary>
    public unsafe bool bClimbingToShimmy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7436); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7436); }
    }

    /// <summary>
    /// BoolProperty: bDebugShimmyMovement
    /// </summary>
    public unsafe bool bDebugShimmyMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7440); }
    }

    /// <summary>
    /// BoolProperty: bDebugShimmyIK
    /// </summary>
    public unsafe bool bDebugShimmyIK
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7440); }
    }

    /// <summary>
    /// BoolProperty: IsQuickThrow
    /// </summary>
    public unsafe bool IsQuickThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7440) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7440); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7440); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideGravity
    /// </summary>
    public unsafe float CapeGlideGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7444); }
    }

    /// <summary>
    /// StructProperty: HairAndCowl
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FHairAndCowlState HairAndCowl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FHairAndCowlState>(Ptr + 7448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7448); }
    }

    /// <summary>
    /// StructProperty: GrappleLoopSoundHandle
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle GrappleLoopSoundHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 7464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7464); }
    }

    /// <summary>
    /// FloatProperty: NoSpeakTimer
    /// </summary>
    public unsafe float NoSpeakTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7480); }
    }

    /// <summary>
    /// FloatProperty: RescueTimer
    /// </summary>
    public unsafe float RescueTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7484); }
    }

    /// <summary>
    /// FloatProperty: PlayerWalkSpeed
    /// </summary>
    public unsafe float PlayerWalkSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7488); }
    }

    /// <summary>
    /// FloatProperty: PlayerRunSpeed
    /// </summary>
    public unsafe float PlayerRunSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7492); }
    }

    /// <summary>
    /// FloatProperty: PlayerStealthSpeed
    /// </summary>
    public unsafe float PlayerStealthSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7496); }
    }

    /// <summary>
    /// FloatProperty: PlayerGlideSpeed
    /// </summary>
    public unsafe float PlayerGlideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7500); }
    }

    /// <summary>
    /// FloatProperty: PlayerChargeStrikeSpeedModifier
    /// </summary>
    public unsafe float PlayerChargeStrikeSpeedModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7504); }
    }

    /// <summary>
    /// ArrayProperty: IceRafts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFloatingRaft> IceRafts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFloatingRaft>>(Ptr + 7508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7508); }
    }

    /// <summary>
    /// FloatProperty: MaxIceRafts
    /// </summary>
    public unsafe float MaxIceRafts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7524); }
    }

    /// <summary>
    /// FloatProperty: GrappleSpeed
    /// </summary>
    public unsafe float GrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7528); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleSpeed
    /// </summary>
    public unsafe float MaxGrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7532); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleSpeed
    /// </summary>
    public unsafe float MinGrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7536); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleSpeedDist
    /// </summary>
    public unsafe float MinGrappleSpeedDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7540); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleSpeedDist
    /// </summary>
    public unsafe float MaxGrappleSpeedDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7544); }
    }

    /// <summary>
    /// FloatProperty: GrappleDampingCoeff
    /// </summary>
    public unsafe float GrappleDampingCoeff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7548); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostFactor
    /// </summary>
    public unsafe float GrappleBoostFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7552); }
    }

    /// <summary>
    /// ArrayProperty: HealthUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> HealthUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 7556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7556); }
    }

    /// <summary>
    /// ArrayProperty: MeleeArmourUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> MeleeArmourUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 7572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7572); }
    }

    /// <summary>
    /// ArrayProperty: BallisticArmourUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> BallisticArmourUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 7588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7588); }
    }

    /// <summary>
    /// ArrayProperty: CurrentArmourLevels
    /// </summary>
    public unsafe BmSDK.TArray<int> CurrentArmourLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 7604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7604); }
    }

    /// <summary>
    /// ArrayProperty: CurrentArmourMaxima
    /// </summary>
    public unsafe BmSDK.TArray<int> CurrentArmourMaxima
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 7620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7620); }
    }

    /// <summary>
    /// FloatProperty: ReplenishRate
    /// </summary>
    public unsafe float ReplenishRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeReplenish
    /// </summary>
    public unsafe float TimeBeforeReplenish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDamage
    /// </summary>
    public unsafe float TimeSinceDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceReplenish
    /// </summary>
    public unsafe float TimeSinceReplenish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7648); }
    }

    /// <summary>
    /// FloatProperty: AccumulatedFloatDamage
    /// </summary>
    public unsafe float AccumulatedFloatDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7652); }
    }

    /// <summary>
    /// StructProperty: CurrentRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FRailingInfo CurrentRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FRailingInfo>(Ptr + 7656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7656); }
    }

    /// <summary>
    /// StructProperty: SecondRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FRailingInfo SecondRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FRailingInfo>(Ptr + 7684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7684); }
    }

    /// <summary>
    /// ArrayProperty: NearRailings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayer.FRailingInfo> NearRailings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayer.FRailingInfo>>(Ptr + 7712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7712); }
    }

    /// <summary>
    /// FloatProperty: CriticalFallHeight
    /// </summary>
    public unsafe float CriticalFallHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7728); }
    }

    /// <summary>
    /// FloatProperty: CriticalFallHeightWarnTime
    /// </summary>
    public unsafe float CriticalFallHeightWarnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7732); }
    }

    /// <summary>
    /// FloatProperty: MinCriticalFallSpeed
    /// </summary>
    public unsafe float MinCriticalFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7736); }
    }

    /// <summary>
    /// FloatProperty: MaxCriticalFallSpeed
    /// </summary>
    public unsafe float MaxCriticalFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7740); }
    }

    /// <summary>
    /// FloatProperty: MinCriticalFallDamage
    /// </summary>
    public unsafe float MinCriticalFallDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7744); }
    }

    /// <summary>
    /// FloatProperty: MaxCriticalFallDamage
    /// </summary>
    public unsafe float MaxCriticalFallDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7748); }
    }

    /// <summary>
    /// StructProperty: CriticalFallImpactLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 CriticalFallImpactLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7752); }
    }

    /// <summary>
    /// FloatProperty: MaxTurnDegreesPerSecond
    /// </summary>
    public unsafe float MaxTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7764); }
    }

    /// <summary>
    /// FloatProperty: GlideTurnDegreesPerSecond
    /// </summary>
    public unsafe float GlideTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7768); }
    }

    /// <summary>
    /// FloatProperty: WalkTurnDegreesPerSecond
    /// </summary>
    public unsafe float WalkTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7772); }
    }

    /// <summary>
    /// FloatProperty: OverrideTime
    /// </summary>
    public unsafe float OverrideTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7776); }
    }

    /// <summary>
    /// ByteProperty: MovementSpeed
    /// </summary>
    public unsafe BmSDK.Engine.RAutomaticTransitions.EMovementSpeed MovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAutomaticTransitions.EMovementSpeed>(Ptr + 7780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7780); }
    }

    /// <summary>
    /// ByteProperty: CurrentPoseType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EBatmanPoseType CurrentPoseType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EBatmanPoseType>(Ptr + 7781); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7781); }
    }

    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7782); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7782); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7783); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7783); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7784); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7785); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7785); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7786); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7786); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7787); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7787); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7788); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7789); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7789); }
    }

    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7790); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7790); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7791); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7791); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7792); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7793); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7793); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7794); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7794); }
    }

    /// <summary>
    /// ByteProperty: CurrentPerchDir
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.PerchDirection CurrentPerchDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.PerchDirection>(Ptr + 7795); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7795); }
    }

    /// <summary>
    /// ByteProperty: CurrentCornerType
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.BatmanCoverCorners CurrentCornerType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.BatmanCoverCorners>(Ptr + 7796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7796); }
    }

    /// <summary>
    /// ByteProperty: ShimmyMoveResult
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EShimmtMoveResult ShimmyMoveResult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EShimmtMoveResult>(Ptr + 7797); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7797); }
    }

    /// <summary>
    /// StructProperty: PreCorrectionVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 PreCorrectionVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7800); }
    }

    /// <summary>
    /// StructProperty: GadgetTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GadgetTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 7812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7812); }
    }

    /// <summary>
    /// FloatProperty: LastDeltaTime
    /// </summary>
    public unsafe float LastDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7816); }
    }

    /// <summary>
    /// StructProperty: DeferedVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 DeferedVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }

    /// <summary>
    /// ArrayProperty: LOSCapeChecks
    /// </summary>
    public unsafe BmSDK.TArray<int> LOSCapeChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 7832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7832); }
    }

    /// <summary>
    /// ArrayProperty: CoverRightLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverRightLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7848); }
    }

    /// <summary>
    /// ArrayProperty: CoverLeftLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverLeftLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7864); }
    }

    /// <summary>
    /// ArrayProperty: HangingLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> HangingLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7880); }
    }

    /// <summary>
    /// ArrayProperty: BracedLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BracedLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7896); }
    }

    /// <summary>
    /// ArrayProperty: HangingLOSCapeChecks
    /// </summary>
    public unsafe BmSDK.TArray<int> HangingLOSCapeChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 7912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7912); }
    }

    /// <summary>
    /// FloatProperty: WallStopCosAngle
    /// </summary>
    public unsafe float WallStopCosAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7928); }
    }

    /// <summary>
    /// FloatProperty: WallStopCheckRadius
    /// </summary>
    public unsafe float WallStopCheckRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7932); }
    }

    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 7936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7936); }
    }
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 7956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7956); }
    }
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 7976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7976); }
    }
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 7996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7996); }
    }
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 8016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8016); }
    }
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 8036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8036); }
    }
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 8056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8056); }
    }
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 8076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8076); }
    }
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 8096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8096); }
    }
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FMovementControllerHistory ControllerHistory_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FMovementControllerHistory>(Ptr + 8116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8116); }
    }

    /// <summary>
    /// IntProperty: ControllerHistoryPosition
    /// </summary>
    public unsafe int ControllerHistoryPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }

    /// <summary>
    /// IntProperty: ControllerHistoryMax
    /// </summary>
    public unsafe int ControllerHistoryMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }

    /// <summary>
    /// InterfaceProperty: PassThroughAdjustMovementDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPassThroughAdjustMovementDirectionInterface PassThroughAdjustMovementDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPassThroughAdjustMovementDirectionInterface>(Ptr + 8144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8144); }
    }

    /// <summary>
    /// FloatProperty: MinCapeGlideTanAngle
    /// </summary>
    public unsafe float MinCapeGlideTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8160); }
    }

    /// <summary>
    /// FloatProperty: MaxCapeGlideTanAngle
    /// </summary>
    public unsafe float MaxCapeGlideTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceAttackTanAngle
    /// </summary>
    public unsafe float MaxPounceAttackTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8168); }
    }

    /// <summary>
    /// FloatProperty: GlideAttackRange
    /// </summary>
    public unsafe float GlideAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }

    /// <summary>
    /// FloatProperty: PounceAttackRange
    /// </summary>
    public unsafe float PounceAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8176); }
    }

    /// <summary>
    /// ArrayProperty: HealthRecoverRate
    /// </summary>
    public unsafe BmSDK.TArray<float> HealthRecoverRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8180); }
    }

    /// <summary>
    /// IntProperty: DeathCount
    /// </summary>
    public unsafe int DeathCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8196); }
    }

    /// <summary>
    /// ArrayProperty: FrontDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FrontDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 8200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8200); }
    }

    /// <summary>
    /// ArrayProperty: BackDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BackDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 8216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8216); }
    }

    /// <summary>
    /// ArrayProperty: ElectricityDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ElectricityDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 8232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8232); }
    }

    /// <summary>
    /// StructProperty: DamageOverlay
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId DamageOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 8248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8248); }
    }

    /// <summary>
    /// FloatProperty: DesiredMovementScale
    /// </summary>
    public unsafe float DesiredMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8256); }
    }

    /// <summary>
    /// FloatProperty: ActualMovementScale
    /// </summary>
    public unsafe float ActualMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }

    /// <summary>
    /// FloatProperty: MovementScaleChangeSpeed
    /// </summary>
    public unsafe float MovementScaleChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8264); }
    }

    /// <summary>
    /// FloatProperty: TunnelSpeedScale
    /// </summary>
    public unsafe float TunnelSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }

    /// <summary>
    /// FloatProperty: FirstPersonSpeedScale
    /// </summary>
    public unsafe float FirstPersonSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8272); }
    }

    /// <summary>
    /// FloatProperty: ActualMovementSpeed
    /// </summary>
    public unsafe float ActualMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8276); }
    }

    /// <summary>
    /// StructProperty: NetworkMoveVector
    /// </summary>
    public unsafe System.Numerics.Vector3 NetworkMoveVector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8280); }
    }

    /// <summary>
    /// ArrayProperty: PoseIdleStances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PoseIdleStances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }

    /// <summary>
    /// IntProperty: ProjectileLaunchId
    /// </summary>
    public unsafe int ProjectileLaunchId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }

    /// <summary>
    /// IntProperty: LastTakedownId
    /// </summary>
    public unsafe int LastTakedownId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8312); }
    }

    /// <summary>
    /// IntProperty: LastTakedownStageAnimId
    /// </summary>
    public unsafe int LastTakedownStageAnimId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8316); }
    }

    /// <summary>
    /// NameProperty: LastTakedownAnimName
    /// </summary>
    public unsafe BmSDK.FName LastTakedownAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8320); }
    }

    /// <summary>
    /// NameProperty: CustomTakedownAnimName
    /// </summary>
    public unsafe BmSDK.FName CustomTakedownAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8328); }
    }

    /// <summary>
    /// StructProperty: vLastPylonForTakedownCheckCheckLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 vLastPylonForTakedownCheckCheckLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8336); }
    }

    /// <summary>
    /// FloatProperty: LastStaggerTime
    /// </summary>
    public unsafe float LastStaggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }

    /// <summary>
    /// FloatProperty: MinShotStaggerTime
    /// </summary>
    public unsafe float MinShotStaggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8352); }
    }

    /// <summary>
    /// IntProperty: DamageResistance
    /// </summary>
    public unsafe int DamageResistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8356); }
    }

    /// <summary>
    /// IntProperty: DamageRemainder
    /// </summary>
    public unsafe int DamageRemainder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8360); }
    }

    /// <summary>
    /// FloatProperty: DryPct
    /// </summary>
    public unsafe float DryPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8364); }
    }

    /// <summary>
    /// NameProperty: DesiredPoseForReplication
    /// </summary>
    public unsafe BmSDK.FName DesiredPoseForReplication
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8368); }
    }

    /// <summary>
    /// IntProperty: PlayerIndex
    /// </summary>
    public unsafe int PlayerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8376); }
    }

    /// <summary>
    /// StructProperty: FallingTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 FallingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8380); }
    }

    /// <summary>
    /// FloatProperty: BoostSpeed
    /// </summary>
    public unsafe float BoostSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }

    /// <summary>
    /// FloatProperty: BoostTime
    /// </summary>
    public unsafe float BoostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8396); }
    }

    /// <summary>
    /// FloatProperty: DefaultBoostSpeed
    /// </summary>
    public unsafe float DefaultBoostSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }

    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8404); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8412); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8420); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8428); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8436); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8444); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8452); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8460); }
    }

    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8468); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8476); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8484); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8492); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8500); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8508); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8516); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8524); }
    }

    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8532); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8540); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8548); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8556); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8564); }
    }

    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 8572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8572); }
    }
    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }
    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }

    /// <summary>
    /// ArrayProperty: connectedChaseGrates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> connectedChaseGrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(Ptr + 8620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8620); }
    }

    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8636); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8640); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8644); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8648); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8652); }
    }

    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8656); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8664); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8672); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8680); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8688); }
    }

    /// <summary>
    /// StructProperty: LastSafeWalkingPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSafeWalkingPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8696); }
    }

    /// <summary>
    /// StructProperty: LastWalkingPostition
    /// </summary>
    public unsafe System.Numerics.Vector3 LastWalkingPostition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8708); }
    }

    /// <summary>
    /// StructProperty: ClimbToCeilingClimbPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbToCeilingClimbPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(Ptr + 8720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8720); }
    }

    /// <summary>
    /// StructProperty: ClimbToCatwalkClimbPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbToCatwalkClimbPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(Ptr + 8852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8852); }
    }

    /// <summary>
    /// StructProperty: LastJumpVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 LastJumpVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8984); }
    }

    /// <summary>
    /// IntProperty: ClimbIndex
    /// </summary>
    public unsafe int ClimbIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8996); }
    }

    /// <summary>
    /// StructProperty: WireBouncer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater WireBouncer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater>(Ptr + 9000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9000); }
    }

    /// <summary>
    /// StructProperty: CurrentCollisionSmoothingForce
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentCollisionSmoothingForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9068); }
    }

    /// <summary>
    /// StructProperty: DesiredCollisionSmoothingForce
    /// </summary>
    public unsafe System.Numerics.Vector3 DesiredCollisionSmoothingForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9080); }
    }

    /// <summary>
    /// FloatProperty: CollisionSmoothingStrength
    /// </summary>
    public unsafe float CollisionSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9092); }
    }

    /// <summary>
    /// FloatProperty: CollisionSmoothingOffStrength
    /// </summary>
    public unsafe float CollisionSmoothingOffStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9096); }
    }

    /// <summary>
    /// FloatProperty: CurrentAvoidAnimStrength
    /// </summary>
    public unsafe float CurrentAvoidAnimStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9100); }
    }

    /// <summary>
    /// FloatProperty: MaxAvoidAnimSpeed
    /// </summary>
    public unsafe float MaxAvoidAnimSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9104); }
    }

    /// <summary>
    /// FloatProperty: AvoidAnimOnStrength
    /// </summary>
    public unsafe float AvoidAnimOnStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9108); }
    }

    /// <summary>
    /// FloatProperty: AvoidAnimOffStrength
    /// </summary>
    public unsafe float AvoidAnimOffStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9112); }
    }

    /// <summary>
    /// StructProperty: CriticalLandScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct CriticalLandScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 9116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9116); }
    }

    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9272); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9276); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9280); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9284); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9288); }
    }

    /// <summary>
    /// FloatProperty: OverrideFallingGravity
    /// </summary>
    public unsafe float OverrideFallingGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9292); }
    }

    /// <summary>
    /// FloatProperty: MaxJumpStrengthToJumpLand
    /// </summary>
    public unsafe float MaxJumpStrengthToJumpLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9296); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldSize
    /// </summary>
    public unsafe float GrappleForceFieldSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9300); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldWidth
    /// </summary>
    public unsafe float GrappleForceFieldWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9304); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldStrength
    /// </summary>
    public unsafe float GrappleForceFieldStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9308); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldStrengthPower
    /// </summary>
    public unsafe float GrappleForceFieldStrengthPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9312); }
    }

    /// <summary>
    /// FloatProperty: GrappleAnimForceFieldFactor
    /// </summary>
    public unsafe float GrappleAnimForceFieldFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9316); }
    }

    /// <summary>
    /// StructProperty: CantRunInDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 CantRunInDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9320); }
    }

    /// <summary>
    /// StructProperty: QuickFireFailedTransitionId
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QuickFireFailedTransitionId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 9332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9332); }
    }

    /// <summary>
    /// StructProperty: ShotOnVantageShaker
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ShotOnVantageShaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 9336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9336); }
    }

    /// <summary>
    /// StructProperty: UnderWaterVolumeLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 UnderWaterVolumeLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9492); }
    }

    /// <summary>
    /// StructProperty: vUnderFearGasEffectLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 vUnderFearGasEffectLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9504); }
    }

    /// <summary>
    /// FloatProperty: JumpStrength
    /// </summary>
    public unsafe float JumpStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9516); }
    }

    /// <summary>
    /// FloatProperty: JumpFallOffRate
    /// </summary>
    public unsafe float JumpFallOffRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9520); }
    }

    /// <summary>
    /// FloatProperty: FallAnimRate
    /// </summary>
    public unsafe float FallAnimRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9524); }
    }

    /// <summary>
    /// FloatProperty: JumpAnimRate
    /// </summary>
    public unsafe float JumpAnimRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9528); }
    }

    /// <summary>
    /// StructProperty: LastRootMotionVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 LastRootMotionVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9532); }
    }

    /// <summary>
    /// FloatProperty: MaxCoverEscapeRange
    /// </summary>
    public unsafe float MaxCoverEscapeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9544); }
    }

    /// <summary>
    /// StructProperty: DamageProxyLastActivePos
    /// </summary>
    public unsafe System.Numerics.Vector3 DamageProxyLastActivePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9548); }
    }

    /// <summary>
    /// StructProperty: InterrogWallSpaceCheckExtents
    /// </summary>
    public unsafe System.Numerics.Vector3 InterrogWallSpaceCheckExtents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9560); }
    }

    /// <summary>
    /// FloatProperty: InterrogWallSpaceCheckHeight
    /// </summary>
    public unsafe float InterrogWallSpaceCheckHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9572); }
    }

    /// <summary>
    /// StructProperty: CollisionSpringVel
    /// </summary>
    public unsafe System.Numerics.Vector3 CollisionSpringVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9576); }
    }

    /// <summary>
    /// StructProperty: FootStepNotifyStruct
    /// </summary>
    public unsafe BmSDK.Engine.AnimNotify.FNotifierInfo FootStepNotifyStruct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNotify.FNotifierInfo>(Ptr + 9588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9588); }
    }

    /// <summary>
    /// IntProperty: attacksSinceGlideKick
    /// </summary>
    public unsafe int attacksSinceGlideKick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9636); }
    }

    /// <summary>
    /// FloatProperty: lastGlideKickTime
    /// </summary>
    public unsafe float lastGlideKickTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9640); }
    }

    /// <summary>
    /// FloatProperty: glideKickTakedownTimeLimit
    /// </summary>
    public unsafe float glideKickTakedownTimeLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9644); }
    }

    /// <summary>
    /// IntProperty: attacksSinceDropAttack
    /// </summary>
    public unsafe int attacksSinceDropAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9648); }
    }

    /// <summary>
    /// FloatProperty: lastDropAttackTime
    /// </summary>
    public unsafe float lastDropAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9652); }
    }

    /// <summary>
    /// FloatProperty: dropAttackTakedownTimeLimit
    /// </summary>
    public unsafe float dropAttackTakedownTimeLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9656); }
    }

    /// <summary>
    /// NameProperty: LastCameraState
    /// </summary>
    public unsafe BmSDK.FName LastCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 9660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9660); }
    }

    /// <summary>
    /// StructProperty: LastCameraRotation
    /// </summary>
    public unsafe BmSDK.Rotator LastCameraRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 9668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9668); }
    }

    /// <summary>
    /// StrProperty: RiddlerCharDataName
    /// </summary>
    public unsafe BmSDK.FString RiddlerCharDataName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 9680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9680); }
    }

    /// <summary>
    /// NameProperty: LastState
    /// </summary>
    public unsafe BmSDK.FName LastState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 9696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9696); }
    }

    /// <summary>
    /// FloatProperty: GlideKickSmashRadius
    /// </summary>
    public unsafe float GlideKickSmashRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9704); }
    }

    /// <summary>
    /// StructProperty: GlideKickSmashScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct GlideKickSmashScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 9708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9708); }
    }

    /// <summary>
    /// FloatProperty: GlideKickContinueCombatTimer
    /// </summary>
    public unsafe float GlideKickContinueCombatTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9864); }
    }

    /// <summary>
    /// StructProperty: CornerLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 CornerLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9868); }
    }

    /// <summary>
    /// StructProperty: CornerRotation
    /// </summary>
    public unsafe BmSDK.Rotator CornerRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 9880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9880); }
    }

    /// <summary>
    /// FloatProperty: CornerLROffset
    /// </summary>
    public unsafe float CornerLROffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9892); }
    }

    /// <summary>
    /// FloatProperty: GrappleDirectionPitchProp
    /// </summary>
    public unsafe float GrappleDirectionPitchProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9896); }
    }

    /// <summary>
    /// FloatProperty: GrappleDirectionYawProp
    /// </summary>
    public unsafe float GrappleDirectionYawProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9900); }
    }

    /// <summary>
    /// FloatProperty: VehicleTakedownRange
    /// </summary>
    public unsafe float VehicleTakedownRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9904); }
    }

    /// <summary>
    /// IntProperty: GasFallsForJoker
    /// </summary>
    public unsafe int GasFallsForJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9908); }
    }

    /// <summary>
    /// IntProperty: RoadObstacleIndex
    /// </summary>
    public unsafe int RoadObstacleIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9912); }
    }

    /// <summary>
    /// ArrayProperty: PreviousAllComponentsList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreviousAllComponentsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 9916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9916); }
    }

    /// <summary>
    /// StructProperty: CustomChangeCameraAimPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 CustomChangeCameraAimPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9932); }
    }

    /// <summary>
    /// FloatProperty: ShimmyMoveTimer
    /// </summary>
    public unsafe float ShimmyMoveTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9944); }
    }

    /// <summary>
    /// FloatProperty: LastShimmyMove
    /// </summary>
    public unsafe float LastShimmyMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9948); }
    }

    /// <summary>
    /// FloatProperty: MinShimmyMove
    /// </summary>
    public unsafe float MinShimmyMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 9952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9952); }
    }

    /// <summary>
    /// StructProperty: LeftHandShimmyOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 LeftHandShimmyOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9956); }
    }

    /// <summary>
    /// StructProperty: RightHandShimmyOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 RightHandShimmyOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9968); }
    }

    /// <summary>
    /// StructProperty: CurrentLeftHandShimmyOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentLeftHandShimmyOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9980); }
    }

    /// <summary>
    /// StructProperty: CurrentRightHandShimmyOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentRightHandShimmyOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 9992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9992); }
    }

    /// <summary>
    /// FloatProperty: ShimmyHandInterpSpeed
    /// </summary>
    public unsafe float ShimmyHandInterpSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10004); }
    }

    /// <summary>
    /// FloatProperty: AccurateShimmyFactor
    /// </summary>
    public unsafe float AccurateShimmyFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10008); }
    }

    /// <summary>
    /// FloatProperty: AccurateShimmyFactorOnoffTime
    /// </summary>
    public unsafe float AccurateShimmyFactorOnoffTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10012); }
    }

    /// <summary>
    /// ArrayProperty: RTPCsToSetToOne
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkParameterName> RTPCsToSetToOne
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkParameterName>>(Ptr + 10016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10016); }
    }
}
