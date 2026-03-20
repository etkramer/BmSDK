#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleNPC<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleNPC : BmSDK.BmGame.RVehicle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleNPC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleNPC() { }

    /// <summary>
    /// Constructs a new RVehicleNPC
    /// </summary>
    public RVehicleNPC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleNPC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleNPC(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPC>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: TurretYawController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone TurretYawController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// ObjectProperty: TurretPitchController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone TurretPitchController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 4568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4568); }
    }

    /// <summary>
    /// ObjectProperty: VehicleSoundInfo
    /// </summary>
    public unsafe BmSDK.Engine.AkVehicleSoundInfo VehicleSoundInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkVehicleSoundInfo>(Ptr + 4576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4576); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.Engine.Pawn Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }

    /// <summary>
    /// ObjectProperty: LeaderVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC LeaderVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }

    /// <summary>
    /// ObjectProperty: FollowVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC FollowVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeImpactParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChallengeImpactParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4608); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChallengeDespawnParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnAkEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChallengeDespawnAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// ObjectProperty: LeaveFormationBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour_RunAway LeaveFormationBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour_RunAway>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAsBombPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VehicleAsBombPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAsEmpPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VehicleAsEmpPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4648); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAsBombExplosionPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VehicleAsBombExplosionPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4656); }
    }

    /// <summary>
    /// ObjectProperty: VehicleAsEmpExplosionPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VehicleAsEmpExplosionPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4664); }
    }

    /// <summary>
    /// ObjectProperty: OracleHackingPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem OracleHackingPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4672); }
    }

    /// <summary>
    /// ObjectProperty: OracleHackedPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem OracleHackedPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4680); }
    }

    /// <summary>
    /// ObjectProperty: DroneHackedEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DroneHackedEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }

    /// <summary>
    /// ObjectProperty: OriginalXrayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant OriginalXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4696); }
    }

    /// <summary>
    /// ObjectProperty: BlindedXrayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BlindedXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4704); }
    }

    /// <summary>
    /// ObjectProperty: DisruptedXrayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DisruptedXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4712); }
    }

    /// <summary>
    /// ObjectProperty: AudioTurretSpeed
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName AudioTurretSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 4720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4720); }
    }

    /// <summary>
    /// ObjectProperty: ShootProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile ShootProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4728); }
    }

    /// <summary>
    /// ObjectProperty: ShootSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ShootSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4736); }
    }

    /// <summary>
    /// ObjectProperty: AttackTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor AttackTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4744); }
    }

    /// <summary>
    /// ObjectProperty: KilledBy
    /// </summary>
    public unsafe BmSDK.Engine.Actor KilledBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4752); }
    }

    /// <summary>
    /// ObjectProperty: VehicleBlockingMyLOS
    /// </summary>
    public unsafe BmSDK.Engine.Actor VehicleBlockingMyLOS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4760); }
    }

    /// <summary>
    /// ObjectProperty: MortarProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RMortarProjectile MortarProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMortarProjectile>(Ptr + 4768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4768); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunFireFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MachineGunFireFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4776); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunTracerFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MachineGunTracerFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4784); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MachineGunEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4792); }
    }

    /// <summary>
    /// ObjectProperty: BlindRTPC
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName BlindRTPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }

    /// <summary>
    /// ObjectProperty: DeadVehicleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadVehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 4808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4808); }
    }

    /// <summary>
    /// ObjectProperty: DeathParticleFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DeathParticleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4816); }
    }

    /// <summary>
    /// ObjectProperty: DeadXrayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DeadXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4824); }
    }

    /// <summary>
    /// ObjectProperty: SmashedVehicleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle SmashedVehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 4832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4832); }
    }

    /// <summary>
    /// ObjectProperty: SmashedParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SmashedParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4840); }
    }

    /// <summary>
    /// ObjectProperty: CrushedParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CrushedParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4848); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DeathExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4856); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionSlowmoSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DeathExplosionSlowmoSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4864); }
    }

    /// <summary>
    /// ObjectProperty: FatalDamageSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FatalDamageSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4872); }
    }

    /// <summary>
    /// ObjectProperty: FatalDamageSlowmoSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FatalDamageSlowmoSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4880); }
    }

    /// <summary>
    /// ObjectProperty: SmashedSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SmashedSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4888); }
    }

    /// <summary>
    /// ObjectProperty: CrushedSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CrushedSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4896); }
    }

    /// <summary>
    /// ObjectProperty: RiotHornSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotHornSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4904); }
    }

    /// <summary>
    /// ObjectProperty: CombatManagerTargetOverride
    /// </summary>
    public unsafe BmSDK.Engine.Actor CombatManagerTargetOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4912); }
    }

    /// <summary>
    /// ObjectProperty: InterrogateAuraMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant InterrogateAuraMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4920); }
    }

    /// <summary>
    /// ObjectProperty: SpawningKismet
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SpawnVehicle SpawningKismet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SpawnVehicle>(Ptr + 4928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4928); }
    }

    /// <summary>
    /// ObjectProperty: WaveController
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_VehicleEnemySpawner WaveController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner>(Ptr + 4936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4936); }
    }

    /// <summary>
    /// ObjectProperty: WeaponDamageFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WeaponDamageFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4944); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour CurrentBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 4952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4952); }
    }

    /// <summary>
    /// ObjectProperty: PassengerExitBarkDef
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef PassengerExitBarkDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 4960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4960); }
    }

    /// <summary>
    /// ObjectProperty: PassengerExitBarkPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnSpeech PassengerExitBarkPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnSpeech>(Ptr + 4968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4968); }
    }

    /// <summary>
    /// ObjectProperty: PassengerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PassengerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4976); }
    }

    /// <summary>
    /// ObjectProperty: PassengersEntering
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PassengersEntering_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 4984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4984); }
    }
    /// <summary>
    /// ObjectProperty: PassengersEntering
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PassengersEntering_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 4992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4992); }
    }
    /// <summary>
    /// ObjectProperty: PassengersEntering
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PassengersEntering_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5000); }
    }
    /// <summary>
    /// ObjectProperty: PassengersEntering
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PassengersEntering_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5008); }
    }

    /// <summary>
    /// ObjectProperty: PassengerDefaultWeaponArchetypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon PassengerDefaultWeaponArchetypes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 5016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5016); }
    }
    /// <summary>
    /// ObjectProperty: PassengerDefaultWeaponArchetypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon PassengerDefaultWeaponArchetypes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 5024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5024); }
    }
    /// <summary>
    /// ObjectProperty: PassengerDefaultWeaponArchetypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon PassengerDefaultWeaponArchetypes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 5032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5032); }
    }
    /// <summary>
    /// ObjectProperty: PassengerDefaultWeaponArchetypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon PassengerDefaultWeaponArchetypes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 5040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5040); }
    }

    /// <summary>
    /// ObjectProperty: LastPassengerInSlot
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LastPassengerInSlot_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5048); }
    }
    /// <summary>
    /// ObjectProperty: LastPassengerInSlot
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LastPassengerInSlot_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5056); }
    }
    /// <summary>
    /// ObjectProperty: LastPassengerInSlot
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LastPassengerInSlot_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5064); }
    }
    /// <summary>
    /// ObjectProperty: LastPassengerInSlot
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LastPassengerInSlot_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 5072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5072); }
    }

    /// <summary>
    /// ObjectProperty: ScannableAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SetScannableDrone ScannableAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SetScannableDrone>(Ptr + 5080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5080); }
    }

    /// <summary>
    /// ObjectProperty: DefaultCombatBehaviourInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour DefaultCombatBehaviourInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 5088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5088); }
    }

    /// <summary>
    /// ObjectProperty: CombatGuardBehaviourInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour CombatGuardBehaviourInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 5096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5096); }
    }

    /// <summary>
    /// ObjectProperty: DelayerDriverBarkOtherConvoPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn DelayerDriverBarkOtherConvoPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 5104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5104); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryFailedThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech SideStoryFailedThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 5112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5112); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryAlreadyActiveThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech SideStoryAlreadyActiveThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 5120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5120); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryCantStopTrackingThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech SideStoryCantStopTrackingThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 5128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5128); }
    }

    /// <summary>
    /// ObjectProperty: AttentionDrawnToPlayerThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech AttentionDrawnToPlayerThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 5136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5136); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5144); }
    }

    /// <summary>
    /// ObjectProperty: HeadShotExplosion
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HeadShotExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5152); }
    }

    /// <summary>
    /// ObjectProperty: SpawningRiotVolume
    /// </summary>
    public unsafe BmSDK.BmGame.ROverworldPopulationVolume SpawningRiotVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROverworldPopulationVolume>(Ptr + 5160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5160); }
    }

    /// <summary>
    /// ObjectProperty: VehicleCustomisation
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleCustomisation VehicleCustomisation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleCustomisation>(Ptr + 5168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5168); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToWinch
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileWinch AttachedToWinch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileWinch>(Ptr + 5176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5176); }
    }

    /// <summary>
    /// ObjectProperty: PullThugDriverFromCar_FromAbove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PullThugDriverFromCar_FromAbove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5184); }
    }

    /// <summary>
    /// ObjectProperty: PullThugDriverFromCar_FromInFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PullThugDriverFromCar_FromInFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5192); }
    }

    /// <summary>
    /// ComponentProperty: CounterIcon
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CounterIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5200); }
    }

    /// <summary>
    /// ClassProperty: CombatGuardBehaviour
    /// </summary>
    public unsafe BmSDK.Class CombatGuardBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5208); }
    }

    /// <summary>
    /// ClassProperty: CombatFlushOutBehaviour
    /// </summary>
    public unsafe BmSDK.Class CombatFlushOutBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5216); }
    }

    /// <summary>
    /// ClassProperty: DefaultCombatBehaviour
    /// </summary>
    public unsafe BmSDK.Class DefaultCombatBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5224); }
    }

    /// <summary>
    /// ClassProperty: HackerSuicideBehaviour
    /// </summary>
    public unsafe BmSDK.Class HackerSuicideBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5232); }
    }

    /// <summary>
    /// ComponentProperty: explosionImpulse
    /// </summary>
    public unsafe BmSDK.Engine.RB_RadialImpulseComponent explosionImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_RadialImpulseComponent>(Ptr + 5240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5240); }
    }

    /// <summary>
    /// ComponentProperty: InterrogateAuraMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent InterrogateAuraMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5248); }
    }

    /// <summary>
    /// ComponentProperty: ThreatComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleThreatComponent ThreatComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleThreatComponent>(Ptr + 5256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5256); }
    }

    /// <summary>
    /// ClassProperty: FatalDamageBehaviour
    /// </summary>
    public unsafe BmSDK.Class FatalDamageBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5264); }
    }

    /// <summary>
    /// ComponentProperty: FatalDamageParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FatalDamageParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5272); }
    }

    /// <summary>
    /// ComponentProperty: MachineGunMuzzleComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MachineGunMuzzleComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5280); }
    }

    /// <summary>
    /// ClassProperty: ShootProjectileClass
    /// </summary>
    public unsafe BmSDK.Class ShootProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5288); }
    }

    /// <summary>
    /// ComponentProperty: DisruptedVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DisruptedVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5296); }
    }

    /// <summary>
    /// ComponentProperty: ParticlesOracleHack
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ParticlesOracleHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5304); }
    }

    /// <summary>
    /// ComponentProperty: ParticlesEMP
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ParticlesEMP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5312); }
    }

    /// <summary>
    /// ClassProperty: DefaultBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class DefaultBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5320); }
    }

    /// <summary>
    /// BoolProperty: bDontPitchCannon
    /// </summary>
    public unsafe bool bDontPitchCannon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: IsFriendly
    /// </summary>
    public unsafe bool IsFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bOnlyDestroyOffScreen
    /// </summary>
    public unsafe bool bOnlyDestroyOffScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanDestroyWithPassengers
    /// </summary>
    public unsafe bool bCanDestroyWithPassengers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCanDestroyWhenAlive
    /// </summary>
    public unsafe bool bCanDestroyWhenAlive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: IsPenguinVan
    /// </summary>
    public unsafe bool IsPenguinVan
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: IsMadHatterCar
    /// </summary>
    public unsafe bool IsMadHatterCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: IsMostWantedApc
    /// </summary>
    public unsafe bool IsMostWantedApc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileCantShoot
    /// </summary>
    public unsafe bool bBatmobileCantShoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bFireflyRemovesAndAddsToPopulation
    /// </summary>
    public unsafe bool bFireflyRemovesAndAddsToPopulation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: FollowIsJoining
    /// </summary>
    public unsafe bool FollowIsJoining
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: FollowIsLeaving
    /// </summary>
    public unsafe bool FollowIsLeaving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bHadFollowers
    /// </summary>
    public unsafe bool bHadFollowers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bChallengeModePawn
    /// </summary>
    public unsafe bool bChallengeModePawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bFadeIn
    /// </summary>
    public unsafe bool bFadeIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bFadeOut
    /// </summary>
    public unsafe bool bFadeOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bShouldTickFade
    /// </summary>
    public unsafe bool bShouldTickFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: DisableDeathBarks
    /// </summary>
    public unsafe bool DisableDeathBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bPlayingDoorAnim
    /// </summary>
    public unsafe bool bPlayingDoorAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bTurretDestroyed
    /// </summary>
    public unsafe bool bTurretDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: DontDestroyNearbyPropsOnSpawn
    /// </summary>
    public unsafe bool DontDestroyNearbyPropsOnSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bSusceptibleToEMP
    /// </summary>
    public unsafe bool bSusceptibleToEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bCompletelyDisabledByEMP
    /// </summary>
    public unsafe bool bCompletelyDisabledByEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: PoweredDown
    /// </summary>
    public unsafe bool PoweredDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: VehicleAsBombEMP
    /// </summary>
    public unsafe bool VehicleAsBombEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: BeingHackedByOracle
    /// </summary>
    public unsafe bool BeingHackedByOracle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bSusceptibleToDroneDisruptor
    /// </summary>
    public unsafe bool bSusceptibleToDroneDisruptor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bDisrupted
    /// </summary>
    public unsafe bool bDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToExplodeBecauseTriedToFireWhenDisrupted
    /// </summary>
    public unsafe bool bWaitingToExplodeBecauseTriedToFireWhenDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: EscortIgnoreBatmobile
    /// </summary>
    public unsafe bool EscortIgnoreBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: AudioTurretSpeedABS
    /// </summary>
    public unsafe bool AudioTurretSpeedABS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: TurretLocked
    /// </summary>
    public unsafe bool TurretLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5328); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5328); }
    }

    /// <summary>
    /// BoolProperty: ShootEnabled
    /// </summary>
    public unsafe bool ShootEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bTurretLooksForward
    /// </summary>
    public unsafe bool bTurretLooksForward
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bTurretLooksForwardWhenDead
    /// </summary>
    public unsafe bool bTurretLooksForwardWhenDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ProjectileCausesRocketBy
    /// </summary>
    public unsafe bool ProjectileCausesRocketBy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: Projectile2CausesRocketBy
    /// </summary>
    public unsafe bool Projectile2CausesRocketBy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bNeedsLOSToShoot
    /// </summary>
    public unsafe bool bNeedsLOSToShoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: SatNavApproachFromBehind
    /// </summary>
    public unsafe bool SatNavApproachFromBehind
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ShootWithMortar
    /// </summary>
    public unsafe bool ShootWithMortar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ShootWithMortarHighAngle
    /// </summary>
    public unsafe bool ShootWithMortarHighAngle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: PotentialMissileThreat
    /// </summary>
    public unsafe bool PotentialMissileThreat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: MachineGunEffectsActive
    /// </summary>
    public unsafe bool MachineGunEffectsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: HasMachineGun
    /// </summary>
    public unsafe bool HasMachineGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: MachineGunAlwaysHits
    /// </summary>
    public unsafe bool MachineGunAlwaysHits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDelayExpodeVFX
    /// </summary>
    public unsafe bool bDelayExpodeVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: DeathExplodeNotCustom
    /// </summary>
    public unsafe bool DeathExplodeNotCustom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: FellInWater
    /// </summary>
    public unsafe bool FellInWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ReSpotIfFellInWater
    /// </summary>
    public unsafe bool ReSpotIfFellInWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: CanBeCrushed
    /// </summary>
    public unsafe bool CanBeCrushed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: CrushedThisFrame
    /// </summary>
    public unsafe bool CrushedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bFatallyDamaged
    /// </summary>
    public unsafe bool bFatallyDamaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: HideBonesOnSmashed
    /// </summary>
    public unsafe bool HideBonesOnSmashed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ForceShowOnHUD
    /// </summary>
    public unsafe bool ForceShowOnHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: ControlledByCombatManager
    /// </summary>
    public unsafe bool ControlledByCombatManager
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bRequiresDriver
    /// </summary>
    public unsafe bool bRequiresDriver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bDamageCancelsAttacks
    /// </summary>
    public unsafe bool bDamageCancelsAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bRammingCancelsAttacks
    /// </summary>
    public unsafe bool bRammingCancelsAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bRammingDamageCooldown
    /// </summary>
    public unsafe bool bRammingDamageCooldown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bInActiveRiotZone
    /// </summary>
    public unsafe bool bInActiveRiotZone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bNearSpawnedWanderers
    /// </summary>
    public unsafe bool bNearSpawnedWanderers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bInterrogationAuraActive
    /// </summary>
    public unsafe bool bInterrogationAuraActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bHeavyArmour
    /// </summary>
    public unsafe bool bHeavyArmour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: bArmourPreventsVisualDamage
    /// </summary>
    public unsafe bool bArmourPreventsVisualDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5332); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5332); }
    }

    /// <summary>
    /// BoolProperty: TakesVisualDamageFromCollisions
    /// </summary>
    public unsafe bool TakesVisualDamageFromCollisions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bOnlyVulnerableToBarge
    /// </summary>
    public unsafe bool bOnlyVulnerableToBarge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bInvincibleWhenOccupied
    /// </summary>
    public unsafe bool bInvincibleWhenOccupied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bInvincibleWhenEscorted
    /// </summary>
    public unsafe bool bInvincibleWhenEscorted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: HasEverBeenAwareOfBatmobile
    /// </summary>
    public unsafe bool HasEverBeenAwareOfBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsInvincible
    /// </summary>
    public unsafe bool bIsInvincible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bHasTakenAnyDamage
    /// </summary>
    public unsafe bool bHasTakenAnyDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bGrabbedByIvyVine
    /// </summary>
    public unsafe bool bGrabbedByIvyVine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bOnlyVulnerableToGoodSideSwipe
    /// </summary>
    public unsafe bool bOnlyVulnerableToGoodSideSwipe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengerExitRequested
    /// </summary>
    public unsafe bool bPassengerExitRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersExitNormally
    /// </summary>
    public unsafe bool bPassengersExitNormally
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersExitRunAway
    /// </summary>
    public unsafe bool bPassengersExitRunAway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersExitForcePlayDoorAnim
    /// </summary>
    public unsafe bool bPassengersExitForcePlayDoorAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: CountsForRamTakedownAchievement
    /// </summary>
    public unsafe bool CountsForRamTakedownAchievement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: AlwaysDoKillCamera
    /// </summary>
    public unsafe bool AlwaysDoKillCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: DroneHacked
    /// </summary>
    public unsafe bool DroneHacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: OccupantsAllowedToChatter
    /// </summary>
    public unsafe bool OccupantsAllowedToChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersExitWhenDestroyed
    /// </summary>
    public unsafe bool bPassengersExitWhenDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysPlayDoorAnimOnExit
    /// </summary>
    public unsafe bool bAlwaysPlayDoorAnimOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bSetPassengersHostileOnExit
    /// </summary>
    public unsafe bool bSetPassengersHostileOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bPassengersUnconsciousWhenDestroyed
    /// </summary>
    public unsafe bool bPassengersUnconsciousWhenDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bHadPassengers
    /// </summary>
    public unsafe bool bHadPassengers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: CombatUseIndoorVision
    /// </summary>
    public unsafe bool CombatUseIndoorVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bUseTurretYawForSpotting
    /// </summary>
    public unsafe bool bUseTurretYawForSpotting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: DoExplosionScreenShake
    /// </summary>
    public unsafe bool DoExplosionScreenShake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: PassengerBarksDisabled
    /// </summary>
    public unsafe bool PassengerBarksDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: PlayingDelayedBark
    /// </summary>
    public unsafe bool PlayingDelayedBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDoExplosionEvenIfNoDeadVehicle
    /// </summary>
    public unsafe bool bDoExplosionEvenIfNoDeadVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bIsRiotGetawayVehicle
    /// </summary>
    public unsafe bool bIsRiotGetawayVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawTrail
    /// </summary>
    public unsafe bool bDebugDrawTrail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: GoingToCombatBehaviour
    /// </summary>
    public unsafe bool GoingToCombatBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: IsInCombat
    /// </summary>
    public unsafe bool IsInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5336); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5336); }
    }

    /// <summary>
    /// BoolProperty: bContainsRiddlerInformant
    /// </summary>
    public unsafe bool bContainsRiddlerInformant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: bNoGlideTakedown
    /// </summary>
    public unsafe bool bNoGlideTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: DoingStaggeredScenarioSpawn
    /// </summary>
    public unsafe bool DoingStaggeredScenarioSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// BoolProperty: IgnoreBatmobileWeaponSounds
    /// </summary>
    public unsafe bool IgnoreBatmobileWeaponSounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5340); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5340); }
    }

    /// <summary>
    /// FloatProperty: BehaviourActivateRange
    /// </summary>
    public unsafe float BehaviourActivateRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5344); }
    }

    /// <summary>
    /// FloatProperty: BehaviourDeactivateRange
    /// </summary>
    public unsafe float BehaviourDeactivateRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }

    /// <summary>
    /// FloatProperty: SteeringLookAheadScale
    /// </summary>
    public unsafe float SteeringLookAheadScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5352); }
    }

    /// <summary>
    /// FloatProperty: TyreFrictionScale
    /// </summary>
    public unsafe float TyreFrictionScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }

    /// <summary>
    /// FloatProperty: DestroyMinPlayerRange
    /// </summary>
    public unsafe float DestroyMinPlayerRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }

    /// <summary>
    /// NameProperty: PawnReferenceName
    /// </summary>
    public unsafe BmSDK.FName PawnReferenceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveJumpRightingTorque
    /// </summary>
    public unsafe float SelfDriveJumpRightingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveJumpForwardForce
    /// </summary>
    public unsafe float SelfDriveJumpForwardForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5376); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveJumpDownForce
    /// </summary>
    public unsafe float SelfDriveJumpDownForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5380); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveStuckRightingTorque
    /// </summary>
    public unsafe float SelfDriveStuckRightingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5384); }
    }

    /// <summary>
    /// FloatProperty: KillPostPassengersExitDelay
    /// </summary>
    public unsafe float KillPostPassengersExitDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5388); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveReverseThrottle
    /// </summary>
    public unsafe float SelfDriveReverseThrottle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5392); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveBackUpThrottle
    /// </summary>
    public unsafe float SelfDriveBackUpThrottle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5396); }
    }

    /// <summary>
    /// IntProperty: MinNumSimultaneousAttacks
    /// </summary>
    public unsafe int MinNumSimultaneousAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5400); }
    }

    /// <summary>
    /// ArrayProperty: Joiners
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> Joiners
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC>>(Ptr + 5404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5404); }
    }

    /// <summary>
    /// ArrayProperty: Followers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> Followers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC>>(Ptr + 5420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5420); }
    }

    /// <summary>
    /// FloatProperty: FollowBehaviourCurrentOffsetBehind
    /// </summary>
    public unsafe float FollowBehaviourCurrentOffsetBehind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5436); }
    }

    /// <summary>
    /// FloatProperty: FollowBehaviourCurrentOffset
    /// </summary>
    public unsafe float FollowBehaviourCurrentOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5440); }
    }

    /// <summary>
    /// FloatProperty: MinRunAwayHistory
    /// </summary>
    public unsafe float MinRunAwayHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }

    /// <summary>
    /// FloatProperty: FadeTimer
    /// </summary>
    public unsafe float FadeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5448); }
    }

    /// <summary>
    /// FloatProperty: AlwaysStasisRange
    /// </summary>
    public unsafe float AlwaysStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5452); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveStuckTime
    /// </summary>
    public unsafe float SelfDriveStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5456); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveReverseTime
    /// </summary>
    public unsafe float SelfDriveReverseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5460); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveRecentlyStuck
    /// </summary>
    public unsafe float SelfDriveRecentlyStuck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5464); }
    }

    /// <summary>
    /// ByteProperty: SelfDriveStuckMode
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.ESelfDriveMode SelfDriveStuckMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.ESelfDriveMode>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }

    /// <summary>
    /// ByteProperty: HelicopterPointOfInterestType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes HelicopterPointOfInterestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes>(Ptr + 5469); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5469); }
    }

    /// <summary>
    /// ByteProperty: CombatEncounterType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.EVehicleCombatEncounterType CombatEncounterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.EVehicleCombatEncounterType>(Ptr + 5470); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5470); }
    }

    /// <summary>
    /// ByteProperty: ImmuneToRamDamageLevel
    /// </summary>
    public unsafe byte ImmuneToRamDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5471); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5471); }
    }

    /// <summary>
    /// ByteProperty: SpawnType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.EVehicleSpawnType SpawnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.EVehicleSpawnType>(Ptr + 5472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5472); }
    }

    /// <summary>
    /// ByteProperty: VehicleGroupType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.EVehicleGroupType VehicleGroupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.EVehicleGroupType>(Ptr + 5473); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5473); }
    }

    /// <summary>
    /// ByteProperty: FallingRescues
    /// </summary>
    public unsafe byte FallingRescues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5474); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5474); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveTrappedTime
    /// </summary>
    public unsafe float SelfDriveTrappedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }

    /// <summary>
    /// StructProperty: SelfDriveTrappedRefPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 SelfDriveTrappedRefPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5480); }
    }

    /// <summary>
    /// StructProperty: SelfDriveTargetLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 SelfDriveTargetLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }

    /// <summary>
    /// FloatProperty: TrappedEventDelay
    /// </summary>
    public unsafe float TrappedEventDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5504); }
    }

    /// <summary>
    /// FloatProperty: VehicleStuckTime
    /// </summary>
    public unsafe float VehicleStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }

    /// <summary>
    /// FloatProperty: TempBoostTime
    /// </summary>
    public unsafe float TempBoostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5512); }
    }

    /// <summary>
    /// FloatProperty: DamageTimeEMP
    /// </summary>
    public unsafe float DamageTimeEMP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }

    /// <summary>
    /// IntProperty: VehicleAsBombHealth
    /// </summary>
    public unsafe int VehicleAsBombHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5520); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsBombBlinkTime
    /// </summary>
    public unsafe float VehicleAsBombBlinkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsBombDamageRadius
    /// </summary>
    public unsafe float VehicleAsBombDamageRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5528); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsBombDamageAmount
    /// </summary>
    public unsafe float VehicleAsBombDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsEmpDamageRadius
    /// </summary>
    public unsafe float VehicleAsEmpDamageRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5536); }
    }

    /// <summary>
    /// FloatProperty: VehicleAsEmpDamageAmount
    /// </summary>
    public unsafe float VehicleAsEmpDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }

    /// <summary>
    /// FloatProperty: OracleHackDuration
    /// </summary>
    public unsafe float OracleHackDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5544); }
    }

    /// <summary>
    /// FloatProperty: OracleHackTime
    /// </summary>
    public unsafe float OracleHackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }

    /// <summary>
    /// StrProperty: OracleHackType
    /// </summary>
    public unsafe BmSDK.FString OracleHackType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5552); }
    }

    /// <summary>
    /// FloatProperty: fBlindedRemainingTime
    /// </summary>
    public unsafe float fBlindedRemainingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5568); }
    }

    /// <summary>
    /// NameProperty: nRHDTargetSocket
    /// </summary>
    public unsafe BmSDK.FName nRHDTargetSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }

    /// <summary>
    /// StrProperty: sRHDScreenTitle
    /// </summary>
    public unsafe BmSDK.FString sRHDScreenTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }

    /// <summary>
    /// ArrayProperty: RemoveMaterialsFromDisruptorMeshList
    /// </summary>
    public unsafe BmSDK.TArray<int> RemoveMaterialsFromDisruptorMeshList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 5596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5596); }
    }

    /// <summary>
    /// StrProperty: sDisruptorHUDDescription
    /// </summary>
    public unsafe BmSDK.FString sDisruptorHUDDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }

    /// <summary>
    /// StrProperty: sDisruptorTrackerHUDDescription
    /// </summary>
    public unsafe BmSDK.FString sDisruptorTrackerHUDDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }

    /// <summary>
    /// NameProperty: DisruptorTargetBone
    /// </summary>
    public unsafe BmSDK.FName DisruptorTargetBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5644); }
    }

    /// <summary>
    /// FloatProperty: TurretRotSpeed
    /// </summary>
    public unsafe float TurretRotSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }

    /// <summary>
    /// FloatProperty: TurretMinPitch
    /// </summary>
    public unsafe float TurretMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5656); }
    }

    /// <summary>
    /// FloatProperty: TurretMaxPitch
    /// </summary>
    public unsafe float TurretMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// FloatProperty: TurretMinYaw
    /// </summary>
    public unsafe float TurretMinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }

    /// <summary>
    /// FloatProperty: TurretMaxYaw
    /// </summary>
    public unsafe float TurretMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }

    /// <summary>
    /// StructProperty: TurretReferencePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 TurretReferencePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5672); }
    }

    /// <summary>
    /// StructProperty: MachineGunReferencePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 MachineGunReferencePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// FloatProperty: TurretYaw
    /// </summary>
    public unsafe float TurretYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5696); }
    }

    /// <summary>
    /// FloatProperty: TurretPitch
    /// </summary>
    public unsafe float TurretPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5700); }
    }

    /// <summary>
    /// FloatProperty: TurretWantYaw
    /// </summary>
    public unsafe float TurretWantYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5704); }
    }

    /// <summary>
    /// FloatProperty: TurretWantPitch
    /// </summary>
    public unsafe float TurretWantPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5708); }
    }

    /// <summary>
    /// StructProperty: TurretLockedRotation
    /// </summary>
    public unsafe BmSDK.Rotator TurretLockedRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 5712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5712); }
    }

    /// <summary>
    /// FloatProperty: ShootInitialDelay
    /// </summary>
    public unsafe float ShootInitialDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5724); }
    }

    /// <summary>
    /// FloatProperty: ShootInitialDelayRand
    /// </summary>
    public unsafe float ShootInitialDelayRand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5728); }
    }

    /// <summary>
    /// FloatProperty: ShootNextDelay
    /// </summary>
    public unsafe float ShootNextDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5732); }
    }

    /// <summary>
    /// FloatProperty: ShootCurDelay
    /// </summary>
    public unsafe float ShootCurDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5736); }
    }

    /// <summary>
    /// FloatProperty: ProjectileFireImpulse
    /// </summary>
    public unsafe float ProjectileFireImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5740); }
    }

    /// <summary>
    /// NameProperty: ProjectileLaunchSocket
    /// </summary>
    public unsafe BmSDK.FName ProjectileLaunchSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5744); }
    }

    /// <summary>
    /// StructProperty: ProjectileLaunchOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 ProjectileLaunchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5752); }
    }

    /// <summary>
    /// NameProperty: Projectile2LaunchSocket
    /// </summary>
    public unsafe BmSDK.FName Projectile2LaunchSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5764); }
    }

    /// <summary>
    /// FloatProperty: OptimalAttackRange
    /// </summary>
    public unsafe float OptimalAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }

    /// <summary>
    /// FloatProperty: MinRoadClearanceToAttack
    /// </summary>
    public unsafe float MinRoadClearanceToAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5776); }
    }

    /// <summary>
    /// FloatProperty: AttackSpacingMultiplier
    /// </summary>
    public unsafe float AttackSpacingMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }

    /// <summary>
    /// FloatProperty: AttackWarningModifier
    /// </summary>
    public unsafe float AttackWarningModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5784); }
    }

    /// <summary>
    /// StructProperty: AttackLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 AttackLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5788); }
    }

    /// <summary>
    /// NameProperty: DroneCombatEvTag
    /// </summary>
    public unsafe BmSDK.FName DroneCombatEvTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5800); }
    }

    /// <summary>
    /// FloatProperty: RunOverDamage
    /// </summary>
    public unsafe float RunOverDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5808); }
    }

    /// <summary>
    /// FloatProperty: MachineGunBurstDuration
    /// </summary>
    public unsafe float MachineGunBurstDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }

    /// <summary>
    /// FloatProperty: MachineGunDamageInterval
    /// </summary>
    public unsafe float MachineGunDamageInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5816); }
    }

    /// <summary>
    /// NameProperty: MachineGunMuzzleSocket
    /// </summary>
    public unsafe BmSDK.FName MachineGunMuzzleSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }

    /// <summary>
    /// FloatProperty: MachineGunShotDeviance
    /// </summary>
    public unsafe float MachineGunShotDeviance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5828); }
    }

    /// <summary>
    /// FloatProperty: MachineGunDamage
    /// </summary>
    public unsafe float MachineGunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5832); }
    }

    /// <summary>
    /// FloatProperty: DeathImpulse
    /// </summary>
    public unsafe float DeathImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// FloatProperty: DeathImpulseRadius
    /// </summary>
    public unsafe float DeathImpulseRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5840); }
    }

    /// <summary>
    /// FloatProperty: DeathExplodeDelay
    /// </summary>
    public unsafe float DeathExplodeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5844); }
    }

    /// <summary>
    /// FloatProperty: DeathDisappearTime
    /// </summary>
    public unsafe float DeathDisappearTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5848); }
    }

    /// <summary>
    /// FloatProperty: DeathExplodeKOThugRadius
    /// </summary>
    public unsafe float DeathExplodeKOThugRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5852); }
    }

    /// <summary>
    /// FloatProperty: DeathExplodeKOThugMomentum
    /// </summary>
    public unsafe float DeathExplodeKOThugMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5856); }
    }

    /// <summary>
    /// NameProperty: DeadVehicleSpawnInLevel
    /// </summary>
    public unsafe BmSDK.FName DeadVehicleSpawnInLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5860); }
    }

    /// <summary>
    /// StructProperty: FlipDeadTorque
    /// </summary>
    public unsafe System.Numerics.Vector3 FlipDeadTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5868); }
    }

    /// <summary>
    /// FloatProperty: FlipDeadDuration
    /// </summary>
    public unsafe float FlipDeadDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5880); }
    }

    /// <summary>
    /// NameProperty: AttachDeathParticleToBone
    /// </summary>
    public unsafe BmSDK.FName AttachDeathParticleToBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// FloatProperty: DeathParticleSystemVelocityFactor
    /// </summary>
    public unsafe float DeathParticleSystemVelocityFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }

    /// <summary>
    /// FloatProperty: DeathParticleSystemVelocityFalloff
    /// </summary>
    public unsafe float DeathParticleSystemVelocityFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5896); }
    }

    /// <summary>
    /// StructProperty: DeathParticleSystemVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 DeathParticleSystemVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5900); }
    }

    /// <summary>
    /// FloatProperty: DeathParticleSystemVelocityTime
    /// </summary>
    public unsafe float DeathParticleSystemVelocityTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5912); }
    }

    /// <summary>
    /// FloatProperty: CrushThreshold
    /// </summary>
    public unsafe float CrushThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5916); }
    }

    /// <summary>
    /// FloatProperty: CrushThresholdZ
    /// </summary>
    public unsafe float CrushThresholdZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }

    /// <summary>
    /// StructProperty: CrushPos
    /// </summary>
    public unsafe System.Numerics.Vector3 CrushPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5924); }
    }

    /// <summary>
    /// StructProperty: CrushNeg
    /// </summary>
    public unsafe System.Numerics.Vector3 CrushNeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5936); }
    }

    /// <summary>
    /// FloatProperty: FatalDamageImpulseMin
    /// </summary>
    public unsafe float FatalDamageImpulseMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5948); }
    }

    /// <summary>
    /// FloatProperty: FatalDamageImpulseMax
    /// </summary>
    public unsafe float FatalDamageImpulseMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5952); }
    }

    /// <summary>
    /// FloatProperty: DeathJumpImpulse
    /// </summary>
    public unsafe float DeathJumpImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5956); }
    }

    /// <summary>
    /// ArrayProperty: DeathExplosionSoundArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> DeathExplosionSoundArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveReverseDuration
    /// </summary>
    public unsafe float SelfDriveReverseDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5976); }
    }

    /// <summary>
    /// StructProperty: DirWhenAttackStarted
    /// </summary>
    public unsafe System.Numerics.Vector3 DirWhenAttackStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5980); }
    }

    /// <summary>
    /// StructProperty: LOSCheckOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 LOSCheckOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5992); }
    }

    /// <summary>
    /// FloatProperty: InterrogationAuraAlpha
    /// </summary>
    public unsafe float InterrogationAuraAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }

    /// <summary>
    /// FloatProperty: WeaponDamageFXScale
    /// </summary>
    public unsafe float WeaponDamageFXScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }

    /// <summary>
    /// FloatProperty: VisualDamageCollisionSpeedScale
    /// </summary>
    public unsafe float VisualDamageCollisionSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6012); }
    }

    /// <summary>
    /// FloatProperty: NudgedByBatmobileTimer
    /// </summary>
    public unsafe float NudgedByBatmobileTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6016); }
    }

    /// <summary>
    /// FloatProperty: AwareOfBatmobileTimer
    /// </summary>
    public unsafe float AwareOfBatmobileTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6020); }
    }

    /// <summary>
    /// IntProperty: NumTimesRammedByBatmobile
    /// </summary>
    public unsafe int NumTimesRammedByBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6024); }
    }

    /// <summary>
    /// FloatProperty: LowVelocityTimer
    /// </summary>
    public unsafe float LowVelocityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6028); }
    }

    /// <summary>
    /// FloatProperty: ChaseIdealDist
    /// </summary>
    public unsafe float ChaseIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6032); }
    }

    /// <summary>
    /// FloatProperty: DroneHackerTime
    /// </summary>
    public unsafe float DroneHackerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6036); }
    }

    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.FVehiclePassenger Passengers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehiclePassenger>(Ptr + 6040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6040); }
    }
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.FVehiclePassenger Passengers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehiclePassenger>(Ptr + 6252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6252); }
    }
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.FVehiclePassenger Passengers_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehiclePassenger>(Ptr + 6464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6464); }
    }
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.FVehiclePassenger Passengers_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehiclePassenger>(Ptr + 6676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6676); }
    }

    /// <summary>
    /// ArrayProperty: UnconsciousPassengers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> UnconsciousPassengers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// StructProperty: CombatMovementRestrictions
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction CombatMovementRestrictions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(Ptr + 6904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6904); }
    }

    /// <summary>
    /// StructProperty: IndoorVisionCones
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet IndoorVisionCones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet>(Ptr + 7072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7072); }
    }

    /// <summary>
    /// StructProperty: OutdoorVisionCones
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet OutdoorVisionCones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet>(Ptr + 7120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7120); }
    }

    /// <summary>
    /// FloatProperty: LOSShootCheckZOffset
    /// </summary>
    public unsafe float LOSShootCheckZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }

    /// <summary>
    /// StructProperty: VisionCones
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet VisionCones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehicleVisionSet>(Ptr + 7172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7172); }
    }

    /// <summary>
    /// StructProperty: ExplosionScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ExplosionScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 7220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7220); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastDriverBark
    /// </summary>
    public unsafe float TimeSinceLastDriverBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7376); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilNextDriverIdleBark
    /// </summary>
    public unsafe float TimeUntilNextDriverIdleBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7380); }
    }

    /// <summary>
    /// IntProperty: PriorityLastDriverBark
    /// </summary>
    public unsafe int PriorityLastDriverBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7384); }
    }

    /// <summary>
    /// NameProperty: LastDriverBarkId
    /// </summary>
    public unsafe BmSDK.FName LastDriverBarkId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7388); }
    }

    /// <summary>
    /// NameProperty: DelayedDriverBarkId
    /// </summary>
    public unsafe BmSDK.FName DelayedDriverBarkId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7396); }
    }

    /// <summary>
    /// IntProperty: DelayedDriverBarkPriority
    /// </summary>
    public unsafe int DelayedDriverBarkPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7404); }
    }

    /// <summary>
    /// FloatProperty: MinDelayBetweenIdleBarks
    /// </summary>
    public unsafe float MinDelayBetweenIdleBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7408); }
    }

    /// <summary>
    /// FloatProperty: MaxDelayBetweenIdleBarks
    /// </summary>
    public unsafe float MaxDelayBetweenIdleBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7412); }
    }

    /// <summary>
    /// FloatProperty: IdleBarkMaxBatmobileDist
    /// </summary>
    public unsafe float IdleBarkMaxBatmobileDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7416); }
    }

    /// <summary>
    /// FloatProperty: BatmobileNearBarkBatmobileDist
    /// </summary>
    public unsafe float BatmobileNearBarkBatmobileDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7420); }
    }

    /// <summary>
    /// FloatProperty: BatmobileNearBarkEscortDist
    /// </summary>
    public unsafe float BatmobileNearBarkEscortDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7424); }
    }

    /// <summary>
    /// StructProperty: DefaultWaveSpawnerProperties
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.FSpawnedVehicleEnemyDesc DefaultWaveSpawnerProperties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner.FSpawnedVehicleEnemyDesc>(Ptr + 7428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7428); }
    }

    /// <summary>
    /// IntProperty: MassResetTimer
    /// </summary>
    public unsafe int MassResetTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7516); }
    }

    /// <summary>
    /// StructProperty: TrailLastPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 TrailLastPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7520); }
    }

    /// <summary>
    /// StructProperty: FireRotationOffset
    /// </summary>
    public unsafe BmSDK.Rotator FireRotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 7532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7532); }
    }

    /// <summary>
    /// FloatProperty: MissileLockOnDuration
    /// </summary>
    public unsafe float MissileLockOnDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7544); }
    }

    /// <summary>
    /// FloatProperty: BehaviourDeltaTimeAcc
    /// </summary>
    public unsafe float BehaviourDeltaTimeAcc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7548); }
    }

    /// <summary>
    /// ArrayProperty: IndependentWeapons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer> IndependentWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer>>(Ptr + 7552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7552); }
    }

    /// <summary>
    /// StructProperty: BatmanTakedownLocationOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmanTakedownLocationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7568); }
    }

    /// <summary>
    /// FloatProperty: AwareOfPlayerTime
    /// </summary>
    public unsafe float AwareOfPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7580); }
    }

    /// <summary>
    /// FloatProperty: AwareOfPlayerMax
    /// </summary>
    public unsafe float AwareOfPlayerMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7584); }
    }

    /// <summary>
    /// IntProperty: LastLevelVolume
    /// </summary>
    public unsafe int LastLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7588); }
    }

    /// <summary>
    /// StructProperty: LastSafeLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSafeLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7592); }
    }

    /// <summary>
    /// StructProperty: LastSafeRotation
    /// </summary>
    public unsafe BmSDK.Rotator LastSafeRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 7604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7604); }
    }

    /// <summary>
    /// FloatProperty: FallingTime
    /// </summary>
    public unsafe float FallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7616); }
    }
}
