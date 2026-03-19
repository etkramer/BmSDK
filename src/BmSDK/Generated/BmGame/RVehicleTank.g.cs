#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleTank<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleTank : BmSDK.BmGame.RVehicleNPC, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleTank", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleTank() { }

    /// <summary>
    /// Constructs a new RVehicleTank
    /// </summary>
    public RVehicleTank(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleTank Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleTank(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleTank>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleTank>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleTank>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleTank>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleTank>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleTank>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleTank>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: TurretPitchController2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurretPitchController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7620); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunPitchController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MachineGunPitchController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// ObjectProperty: MachineGunSpinController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MachineGunSpinController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// ObjectProperty: LeftCatTrackAnimNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftCatTrackAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }

    /// <summary>
    /// ObjectProperty: RightCatTrackAnimNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightCatTrackAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7652); }
    }

    /// <summary>
    /// ObjectProperty: LeftCatCogsAnimNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftCatCogsAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7660); }
    }

    /// <summary>
    /// ObjectProperty: RightCatCogsAnimNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightCatCogsAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7668); }
    }

    /// <summary>
    /// ObjectProperty: FireWeaponAnimNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireWeaponAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7676); }
    }

    /// <summary>
    /// ObjectProperty: LeftTrackController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftTrackController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7684); }
    }

    /// <summary>
    /// ObjectProperty: RightTrackController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightTrackController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7692); }
    }

    /// <summary>
    /// ObjectProperty: LeftWheelsController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftWheelsController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7700); }
    }

    /// <summary>
    /// ObjectProperty: RightWheelsController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightWheelsController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7708); }
    }

    /// <summary>
    /// ObjectProperty: LeftCatTrackAnimNode2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftCatTrackAnimNode2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7716); }
    }

    /// <summary>
    /// ObjectProperty: RightCatTrackAnimNode2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightCatTrackAnimNode2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7724); }
    }

    /// <summary>
    /// ObjectProperty: LeftCatCogsAnimNode2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftCatCogsAnimNode2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7732); }
    }

    /// <summary>
    /// ObjectProperty: RightCatCogsAnimNode2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightCatCogsAnimNode2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7740); }
    }

    /// <summary>
    /// ObjectProperty: LeftTrackController2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftTrackController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7748); }
    }

    /// <summary>
    /// ObjectProperty: RightTrackController2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightTrackController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7756); }
    }

    /// <summary>
    /// ObjectProperty: LeftWheelsController2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftWheelsController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7764); }
    }

    /// <summary>
    /// ObjectProperty: RightWheelsController2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightWheelsController2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7772); }
    }

    /// <summary>
    /// ObjectProperty: MissileProjectileArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MissileProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7780); }
    }

    /// <summary>
    /// ObjectProperty: ShieldMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShieldMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7788); }
    }

    /// <summary>
    /// ObjectProperty: FlushOutProjectileArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlushOutProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7796); }
    }

    /// <summary>
    /// ObjectProperty: BattleViewMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BattleViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7804); }
    }

    /// <summary>
    /// ObjectProperty: HeadShotSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeadShotSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7812); }
    }

    /// <summary>
    /// ObjectProperty: HeadShotBodySound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeadShotBodySound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }

    /// <summary>
    /// ObjectProperty: SpottedPlayerSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpottedPlayerSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7828); }
    }

    /// <summary>
    /// ComponentProperty: BattleViewMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BattleViewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7836); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 7844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7844); }
    }

    /// <summary>
    /// BoolProperty: bPlayingFireAnim
    /// </summary>
    public unsafe bool bPlayingFireAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: MissileCausesRocketBy
    /// </summary>
    public unsafe bool MissileCausesRocketBy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: FrontArmour
    /// </summary>
    public unsafe bool FrontArmour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: TryToAvoidObstacles
    /// </summary>
    public unsafe bool TryToAvoidObstacles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: ShieldedTurret
    /// </summary>
    public unsafe bool ShieldedTurret
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bLeadTargetWithCannon
    /// </summary>
    public unsafe bool bLeadTargetWithCannon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bDoingMissileVolley
    /// </summary>
    public unsafe bool bDoingMissileVolley
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bPerformingIndirectAttack
    /// </summary>
    public unsafe bool bPerformingIndirectAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bShowWeaponWarning
    /// </summary>
    public unsafe bool bShowWeaponWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveTurningOnSpot
    /// </summary>
    public unsafe bool SelfDriveTurningOnSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bUseBoneInsteadOfHeightForDisruptorValidityCheck
    /// </summary>
    public unsafe bool bUseBoneInsteadOfHeightForDisruptorValidityCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: bHeadshotDamageOnly
    /// </summary>
    public unsafe bool bHeadshotDamageOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
    }

    /// <summary>
    /// BoolProperty: TurretShot
    /// </summary>
    public unsafe bool TurretShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7852); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MissileLaunchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 7900); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation>>> VolleyAttackLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation>>>>(Ptr + 7948); }
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
    public unsafe byte ActiveEncounterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7980); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TurretToMuzzleOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 7988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7988); }
    }

    /// <summary>
    /// StructProperty: TurretToMuzzleOffsetIncX
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TurretToMuzzleOffsetIncX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8000); }
    }

    /// <summary>
    /// StructProperty: TurretToMuzzle2OffsetIncX
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TurretToMuzzle2OffsetIncX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8012); }
    }

    /// <summary>
    /// StructProperty: TurretBaseOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TurretBaseOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8024); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation>> MissileLaunchSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation>>>(Ptr + 8048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8048); }
    }

    /// <summary>
    /// StructProperty: MissileFireRotationOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MissileFireRotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8064); }
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
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation> EyeShotSockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.VehicleCustomisation>>(Ptr + 8080); }
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
