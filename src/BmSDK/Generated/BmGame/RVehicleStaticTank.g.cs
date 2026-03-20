#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleStaticTank<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleStaticTank : BmSDK.BmGame.RVehicleTank, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleStaticTank", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleStaticTank() { }

    /// <summary>
    /// Constructs a new RVehicleStaticTank
    /// </summary>
    public RVehicleStaticTank(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleStaticTank Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleStaticTank(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleStaticTank>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleStaticTank>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleStaticTank>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleStaticTank>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleStaticTank>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleStaticTank>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleStaticTank>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: TurretPitchController2
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone TurretPitchController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 7620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7620); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunPitchController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone MachineGunPitchController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunSpinController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone MachineGunSpinController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// ObjectProperty: LeftCatTrackAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence LeftCatTrackAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }

    /// <summary>
    /// ObjectProperty: RightCatTrackAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence RightCatTrackAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7652); }
    }

    /// <summary>
    /// ObjectProperty: LeftCatCogsAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence LeftCatCogsAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7660); }
    }

    /// <summary>
    /// ObjectProperty: RightCatCogsAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence RightCatCogsAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7668); }
    }

    /// <summary>
    /// ObjectProperty: FireWeaponAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence FireWeaponAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7676); }
    }

    /// <summary>
    /// ObjectProperty: LeftTrackController
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControlTankTrack LeftTrackController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControlTankTrack>(Ptr + 7684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7684); }
    }

    /// <summary>
    /// ObjectProperty: RightTrackController
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControlTankTrack RightTrackController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControlTankTrack>(Ptr + 7692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7692); }
    }

    /// <summary>
    /// ObjectProperty: LeftWheelsController
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControlTankTrack LeftWheelsController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControlTankTrack>(Ptr + 7700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7700); }
    }

    /// <summary>
    /// ObjectProperty: RightWheelsController
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControlTankTrack RightWheelsController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControlTankTrack>(Ptr + 7708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7708); }
    }

    /// <summary>
    /// ObjectProperty: LeftCatTrackAnimNode2
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence LeftCatTrackAnimNode2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7716); }
    }

    /// <summary>
    /// ObjectProperty: RightCatTrackAnimNode2
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence RightCatTrackAnimNode2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7724); }
    }

    /// <summary>
    /// ObjectProperty: LeftCatCogsAnimNode2
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence LeftCatCogsAnimNode2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7732); }
    }

    /// <summary>
    /// ObjectProperty: RightCatCogsAnimNode2
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence RightCatCogsAnimNode2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7740); }
    }

    /// <summary>
    /// ObjectProperty: LeftTrackController2
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControlTankTrack LeftTrackController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControlTankTrack>(Ptr + 7748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7748); }
    }

    /// <summary>
    /// ObjectProperty: RightTrackController2
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControlTankTrack RightTrackController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControlTankTrack>(Ptr + 7756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7756); }
    }

    /// <summary>
    /// ObjectProperty: LeftWheelsController2
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControlTankTrack LeftWheelsController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControlTankTrack>(Ptr + 7764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7764); }
    }

    /// <summary>
    /// ObjectProperty: RightWheelsController2
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControlTankTrack RightWheelsController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControlTankTrack>(Ptr + 7772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7772); }
    }

    /// <summary>
    /// ObjectProperty: MissileProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile MissileProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 7780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7780); }
    }

    /// <summary>
    /// ObjectProperty: ShieldMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh ShieldMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 7788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7788); }
    }

    /// <summary>
    /// ObjectProperty: FlushOutProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile FlushOutProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 7796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7796); }
    }

    /// <summary>
    /// ObjectProperty: BattleViewMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface BattleViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 7804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7804); }
    }

    /// <summary>
    /// ObjectProperty: HeadShotSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HeadShotSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 7812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7812); }
    }

    /// <summary>
    /// ObjectProperty: HeadShotBodySound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HeadShotBodySound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }

    /// <summary>
    /// ObjectProperty: SpottedPlayerSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SpottedPlayerSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 7828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7828); }
    }

    /// <summary>
    /// ComponentProperty: BattleViewMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BattleViewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7836); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 7844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7844); }
    }

    /// <summary>
    /// BoolProperty: bPlayingFireAnim
    /// </summary>
    public unsafe bool bPlayingFireAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: MissileCausesRocketBy
    /// </summary>
    public unsafe bool MissileCausesRocketBy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: FrontArmour
    /// </summary>
    public unsafe bool FrontArmour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: TryToAvoidObstacles
    /// </summary>
    public unsafe bool TryToAvoidObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: ShieldedTurret
    /// </summary>
    public unsafe bool ShieldedTurret
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bLeadTargetWithCannon
    /// </summary>
    public unsafe bool bLeadTargetWithCannon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bDoingMissileVolley
    /// </summary>
    public unsafe bool bDoingMissileVolley
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bPerformingIndirectAttack
    /// </summary>
    public unsafe bool bPerformingIndirectAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bShowWeaponWarning
    /// </summary>
    public unsafe bool bShowWeaponWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveTurningOnSpot
    /// </summary>
    public unsafe bool SelfDriveTurningOnSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bUseBoneInsteadOfHeightForDisruptorValidityCheck
    /// </summary>
    public unsafe bool bUseBoneInsteadOfHeightForDisruptorValidityCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bHeadshotDamageOnly
    /// </summary>
    public unsafe bool bHeadshotDamageOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: TurretShot
    /// </summary>
    public unsafe bool TurretShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// IntProperty: WheelIndexFL
    /// </summary>
    public unsafe int WheelIndexFL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7856); }
    }

    /// <summary>
    /// IntProperty: WheelIndexFR
    /// </summary>
    public unsafe int WheelIndexFR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7860); }
    }

    /// <summary>
    /// IntProperty: WheelIndexRL
    /// </summary>
    public unsafe int WheelIndexRL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7864); }
    }

    /// <summary>
    /// IntProperty: WheelIndexRR
    /// </summary>
    public unsafe int WheelIndexRR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7868); }
    }

    /// <summary>
    /// IntProperty: WheelIndexFL2
    /// </summary>
    public unsafe int WheelIndexFL2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7872); }
    }

    /// <summary>
    /// IntProperty: WheelIndexFR2
    /// </summary>
    public unsafe int WheelIndexFR2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7876); }
    }

    /// <summary>
    /// IntProperty: WheelIndexRL2
    /// </summary>
    public unsafe int WheelIndexRL2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7880); }
    }

    /// <summary>
    /// IntProperty: WheelIndexRR2
    /// </summary>
    public unsafe int WheelIndexRR2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7884); }
    }

    /// <summary>
    /// FloatProperty: MachineGunSpin
    /// </summary>
    public unsafe float MachineGunSpin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7888); }
    }

    /// <summary>
    /// FloatProperty: MachineGunSpinVel
    /// </summary>
    public unsafe float MachineGunSpinVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7892); }
    }

    /// <summary>
    /// IntProperty: NumMissilesPerVolley
    /// </summary>
    public unsafe int NumMissilesPerVolley
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7896); }
    }

    /// <summary>
    /// StructProperty: MissileLaunchOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 MissileLaunchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7900); }
    }

    /// <summary>
    /// FloatProperty: MissileFireInterval
    /// </summary>
    public unsafe float MissileFireInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7912); }
    }

    /// <summary>
    /// FloatProperty: MissileFireTimer
    /// </summary>
    public unsafe float MissileFireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7916); }
    }

    /// <summary>
    /// FloatProperty: AttackTimeBonus
    /// </summary>
    public unsafe float AttackTimeBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7920); }
    }

    /// <summary>
    /// IntProperty: NumSimultaneousAttackSlots
    /// </summary>
    public unsafe int NumSimultaneousAttackSlots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7924); }
    }

    /// <summary>
    /// FloatProperty: CatTrackAnimScale
    /// </summary>
    public unsafe float CatTrackAnimScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7928); }
    }

    /// <summary>
    /// IntProperty: VolleyNum
    /// </summary>
    public unsafe int VolleyNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7932); }
    }

    /// <summary>
    /// FloatProperty: VolleyInterval
    /// </summary>
    public unsafe float VolleyInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7936); }
    }

    /// <summary>
    /// FloatProperty: VolleyAngle
    /// </summary>
    public unsafe float VolleyAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7940); }
    }

    /// <summary>
    /// IntProperty: CurrentVolleyIdx
    /// </summary>
    public unsafe int CurrentVolleyIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7944); }
    }

    /// <summary>
    /// ArrayProperty: VolleyAttackLocations
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> VolleyAttackLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 7948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7948); }
    }

    /// <summary>
    /// FloatProperty: MissileVolleyChance
    /// </summary>
    public unsafe float MissileVolleyChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7964); }
    }

    /// <summary>
    /// IntProperty: MissileVolleyNum
    /// </summary>
    public unsafe int MissileVolleyNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7968); }
    }

    /// <summary>
    /// FloatProperty: MissileVolleyInterval
    /// </summary>
    public unsafe float MissileVolleyInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7972); }
    }

    /// <summary>
    /// IntProperty: MissileVolleyMaxHealth
    /// </summary>
    public unsafe int MissileVolleyMaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7976); }
    }

    /// <summary>
    /// ByteProperty: ActiveEncounterType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC.EVehicleCombatEncounterType ActiveEncounterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.EVehicleCombatEncounterType>(Ptr + 7980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7980); }
    }

    /// <summary>
    /// FloatProperty: TankSteerScale
    /// </summary>
    public unsafe float TankSteerScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7984); }
    }

    /// <summary>
    /// StructProperty: TurretToMuzzleOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 TurretToMuzzleOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7988); }
    }

    /// <summary>
    /// StructProperty: TurretToMuzzleOffsetIncX
    /// </summary>
    public unsafe System.Numerics.Vector3 TurretToMuzzleOffsetIncX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8000); }
    }

    /// <summary>
    /// StructProperty: TurretToMuzzle2OffsetIncX
    /// </summary>
    public unsafe System.Numerics.Vector3 TurretToMuzzle2OffsetIncX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8012); }
    }

    /// <summary>
    /// StructProperty: TurretBaseOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 TurretBaseOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8024); }
    }

    /// <summary>
    /// NameProperty: nBoneNameUsedForDisruptorValidityCheck
    /// </summary>
    public unsafe BmSDK.FName nBoneNameUsedForDisruptorValidityCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8036); }
    }

    /// <summary>
    /// FloatProperty: DisruptorHeadShotHeight
    /// </summary>
    public unsafe float DisruptorHeadShotHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8044); }
    }

    /// <summary>
    /// ArrayProperty: MissileLaunchSocket
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MissileLaunchSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 8048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8048); }
    }

    /// <summary>
    /// StructProperty: MissileFireRotationOffset
    /// </summary>
    public unsafe BmSDK.Rotator MissileFireRotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 8064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8064); }
    }

    /// <summary>
    /// FloatProperty: MinFireTime
    /// </summary>
    public unsafe float MinFireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8076); }
    }

    /// <summary>
    /// ArrayProperty: EyeShotSockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> EyeShotSockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 8080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8080); }
    }

    /// <summary>
    /// NameProperty: TurretBaseBoneName
    /// </summary>
    public unsafe BmSDK.FName TurretBaseBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8096); }
    }

    /// <summary>
    /// IntProperty: EyeShotsToKill
    /// </summary>
    public unsafe int EyeShotsToKill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8104); }
    }

    /// <summary>
    /// IntProperty: LightsMaterialIndex
    /// </summary>
    public unsafe int LightsMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8108); }
    }
}
