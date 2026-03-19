#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMagneticBlastReceiver<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RMagneticBlastReceiver : BmSDK.BmGame.RProjectile, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMagneticBlastReceiver", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMagneticBlastReceiver() { }

    /// <summary>
    /// Constructs a new RMagneticBlastReceiver
    /// </summary>
    public RMagneticBlastReceiver(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMagneticBlastReceiver Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMagneticBlastReceiver(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticBlastReceiver>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlastReceiver>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticBlastReceiver>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlastReceiver>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlastReceiver>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticBlastReceiver>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlastReceiver>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: ReceiverMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReceiverMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToMagneticTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AttachedToMagneticTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToVillain
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AttachedToVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToFreezeBoss
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AttachedToFreezeBoss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ObjectProperty: LastHitActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastHitActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ObjectProperty: MagneticForceField
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MagneticForceField
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ObjectProperty: HomingTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HomingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ObjectProperty: MagneticObjects
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MagneticObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: NegLoopSoundEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NegLoopSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ObjectProperty: PosLoopSoundEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PosLoopSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ObjectProperty: MagnetLoopEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MagnetLoopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ObjectProperty: MotorLoopEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MotorLoopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ObjectProperty: SuperComboBlastSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SuperComboBlastSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: BeamTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BeamTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ObjectProperty: SurfaceFXTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SurfaceFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: RepelFXTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RepelFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: AttractFXTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AttractFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: FailFXTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FailFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ObjectProperty: DoorActivationFXTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DoorActivationFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ObjectProperty: RiddlerSwitchEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RiddlerSwitchEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ObjectProperty: ArmouredThugHitFXTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ArmouredThugHitFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ObjectProperty: ArmouredThugZapFXTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ArmouredThugZapFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ObjectProperty: ArmouredImpactSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ArmouredImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ObjectProperty: MagBlast
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MagBlast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Trail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ArrayProperty: InfluencedArmouredVillains
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>> InfluencedArmouredVillains
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: EnergyLeft
    /// </summary>
    public unsafe float EnergyLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ArrayProperty: DynamicItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>> DynamicItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: TimeDeployed
    /// </summary>
    public unsafe float TimeDeployed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// StructProperty: Direction
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Direction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bDetonated
    /// </summary>
    public unsafe bool bDetonated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDeployed
    /// </summary>
    public unsafe bool bDeployed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bActivated
    /// </summary>
    public unsafe bool bActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDelayMagneticEffects
    /// </summary>
    public unsafe bool bDelayMagneticEffects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bFlying
    /// </summary>
    public unsafe bool bFlying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bSuperComboBlast
    /// </summary>
    public unsafe bool bSuperComboBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bLaunchedFromGarg
    /// </summary>
    public unsafe bool bLaunchedFromGarg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bIsCombatFire
    /// </summary>
    public unsafe bool bIsCombatFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bPlayingMagnetLoop
    /// </summary>
    public unsafe bool bPlayingMagnetLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bPlayingMotorLoop
    /// </summary>
    public unsafe bool bPlayingMotorLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bHitTarget
    /// </summary>
    public unsafe bool bHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bKeepSFXAlive
    /// </summary>
    public unsafe bool bKeepSFXAlive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bPlayingSFX
    /// </summary>
    public unsafe bool bPlayingSFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bEmergencyStopped
    /// </summary>
    public unsafe bool bEmergencyStopped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreHitsUntilDischarge
    /// </summary>
    public unsafe bool bIgnoreHitsUntilDischarge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bDestroyGeneratorWhenDetonated
    /// </summary>
    public unsafe bool bDestroyGeneratorWhenDetonated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// BoolProperty: bAvoidedTarget
    /// </summary>
    public unsafe bool bAvoidedTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// StructProperty: LastHitLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastHitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// StructProperty: LastHitNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastHitNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// StructProperty: LaunchPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LaunchPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// FloatProperty: ChargeTime
    /// </summary>
    public unsafe float ChargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ByteProperty: ImpulseType
    /// </summary>
    public unsafe byte ImpulseType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ArrayProperty: Beams
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> Beams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// StructProperty: MinBeamExtents
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MinBeamExtents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// StructProperty: MaxBeamExtents
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaxBeamExtents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: MaxBeamPointDistance
    /// </summary>
    public unsafe float MaxBeamPointDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ArrayProperty: OldCombatThrownObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> OldCombatThrownObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ArrayProperty: CombatThrownObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> CombatThrownObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// IntProperty: LaunchID
    /// </summary>
    public unsafe int LaunchID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }
}
