#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAbandonedVehicle<br/>
/// (flags = 0)
/// </summary>
public partial class RAbandonedVehicle : BmSDK.BmGame.RSkeletalMeshActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAbandonedVehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAbandonedVehicle() { }

    /// <summary>
    /// Constructs a new RAbandonedVehicle
    /// </summary>
    public RAbandonedVehicle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAbandonedVehicle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAbandonedVehicle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAbandonedVehicle>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAbandonedVehicle>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAbandonedVehicle>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAbandonedVehicle>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAbandonedVehicle>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAbandonedVehicle>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAbandonedVehicle>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObject
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: VehicleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC VehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: DeadVehicleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadVehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: SmashedVehicleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle SmashedVehicleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ObjectProperty: DeathParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DeathParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ObjectProperty: SmashedParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SmashedParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ObjectProperty: CrushedParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CrushedParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DeathExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ObjectProperty: SmashedSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SmashedSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: CrushedSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CrushedSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ObjectProperty: StartCarAlarmEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StartCarAlarmEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ObjectProperty: Suppression
    /// </summary>
    public unsafe BmSDK.Engine.AkPredicate Suppression
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkPredicate>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ObjectProperty: StartElectricalOverloadEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StartElectricalOverloadEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ObjectProperty: StartElectricalOverloadEvent2
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StartElectricalOverloadEvent2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: RoofLightsOnEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RoofLightsOnEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ObjectProperty: RainMP
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RainMP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: ObstacleRoads
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork ObstacleRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: InitialAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet InitialAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: WindowSmashEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WindowSmashEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ObjectProperty: VehicleCustomisation
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleCustomisation VehicleCustomisation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleCustomisation>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToWinch
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileWinch AttachedToWinch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileWinch>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ClassProperty: DeathDamageType
    /// </summary>
    public unsafe BmSDK.Class DeathDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ComponentProperty: MolotovCarFire
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MolotovCarFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ComponentProperty: Interactions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ComponentProperty: HitMaskComp
    /// </summary>
    public unsafe BmSDK.Engine.SceneCapture2DHitMaskComponent HitMaskComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SceneCapture2DHitMaskComponent>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ComponentProperty: VisualDamageComp
    /// </summary>
    public unsafe BmSDK.BmGame.RVisualDamageComponent VisualDamageComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVisualDamageComponent>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }
    /// <summary>
    /// StructProperty: VehicleLights
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FVehicleLight VehicleLights_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FVehicleLight>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// BoolProperty: HideBonesOnSmashed
    /// </summary>
    public unsafe bool HideBonesOnSmashed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: DoExplosionScreenShake
    /// </summary>
    public unsafe bool DoExplosionScreenShake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: CanBeCrushed
    /// </summary>
    public unsafe bool CanBeCrushed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: IsFriendly
    /// </summary>
    public unsafe bool IsFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: IsComplexAbandoned
    /// </summary>
    public unsafe bool IsComplexAbandoned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: CopyMaterialsOnDeath
    /// </summary>
    public unsafe bool CopyMaterialsOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: LightsInitialised
    /// </summary>
    public unsafe bool LightsInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: PawnCollision_DebugVisualisation
    /// </summary>
    public unsafe bool PawnCollision_DebugVisualisation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bCanRegisterObstacle
    /// </summary>
    public unsafe bool bCanRegisterObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bDoVehicleXrayUpdate
    /// </summary>
    public unsafe bool bDoVehicleXrayUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bObstacleRegistered
    /// </summary>
    public unsafe bool bObstacleRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bDisabledObstaclePolys
    /// </summary>
    public unsafe bool bDisabledObstaclePolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bObstacleRegisteredAsDynamic
    /// </summary>
    public unsafe bool bObstacleRegisteredAsDynamic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bQueuedObstacleRemove
    /// </summary>
    public unsafe bool bQueuedObstacleRemove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bDoubleObstructionSize
    /// </summary>
    public unsafe bool bDoubleObstructionSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bPostBeginPlayCalled
    /// </summary>
    public unsafe bool bPostBeginPlayCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bPreStreamOutCalled
    /// </summary>
    public unsafe bool bPreStreamOutCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bDestroyedCalled
    /// </summary>
    public unsafe bool bDestroyedCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: IsHeavyAbandoned
    /// </summary>
    public unsafe bool IsHeavyAbandoned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: HeadlightsSwitchedOn
    /// </summary>
    public unsafe bool HeadlightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: InteriorLightsSwitchedOn
    /// </summary>
    public unsafe bool InteriorLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: AuxLightsSwitchedOn
    /// </summary>
    public unsafe bool AuxLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: RoofLightsSwitchedOn
    /// </summary>
    public unsafe bool RoofLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: CarAlarmSwitchedOn
    /// </summary>
    public unsafe bool CarAlarmSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: HasCarAlarm
    /// </summary>
    public unsafe bool HasCarAlarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: HazardLightsSwitchedOn
    /// </summary>
    public unsafe bool HazardLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: TankLightsSwitchedOn
    /// </summary>
    public unsafe bool TankLightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: InitialAnimIncludesChassis
    /// </summary>
    public unsafe bool InitialAnimIncludesChassis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bHasSetWindowMIC
    /// </summary>
    public unsafe bool bHasSetWindowMIC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bOnFire
    /// </summary>
    public unsafe bool bOnFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: FellInWater
    /// </summary>
    public unsafe bool FellInWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: BumpedByCar
    /// </summary>
    public unsafe bool BumpedByCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1912); }
    }

    /// <summary>
    /// BoolProperty: bDamagedOrBumped
    /// </summary>
    public unsafe bool bDamagedOrBumped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRBC
    /// </summary>
    public unsafe bool bIgnoreRBC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bSkipCheckForVehicleIntersection
    /// </summary>
    public unsafe bool bSkipCheckForVehicleIntersection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: LodFixingDisabled
    /// </summary>
    public unsafe bool LodFixingDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bCanHurtNPCsInRangeWhenExploding
    /// </summary>
    public unsafe bool bCanHurtNPCsInRangeWhenExploding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: CrushedThisFrame
    /// </summary>
    public unsafe bool CrushedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bPreCutFromNavMesh
    /// </summary>
    public unsafe bool bPreCutFromNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bTryToPreCut
    /// </summary>
    public unsafe bool bTryToPreCut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bIsPreCut
    /// </summary>
    public unsafe bool bIsPreCut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bDisablePreCuttingByDefault
    /// </summary>
    public unsafe bool bDisablePreCuttingByDefault
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenPreCut
    /// </summary>
    public unsafe bool bHasBeenPreCut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bClearedNavMeshEdgeCosts
    /// </summary>
    public unsafe bool bClearedNavMeshEdgeCosts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bShouldForceRegisteredPolys
    /// </summary>
    public unsafe bool bShouldForceRegisteredPolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bHasForcedRegisteredPolys
    /// </summary>
    public unsafe bool bHasForcedRegisteredPolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileCantShoot
    /// </summary>
    public unsafe bool bBatmobileCantShoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bHasCachedNavMeshShape
    /// </summary>
    public unsafe bool bHasCachedNavMeshShape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bHasCachedNavMeshShapeSuccessfully
    /// </summary>
    public unsafe bool bHasCachedNavMeshShapeSuccessfully
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// FloatProperty: DeathJumpImpulse
    /// </summary>
    public unsafe float DeathJumpImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// FloatProperty: DeathExplodeDelay
    /// </summary>
    public unsafe float DeathExplodeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// FloatProperty: DeathImpulse
    /// </summary>
    public unsafe float DeathImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: DeathImpulseRadius
    /// </summary>
    public unsafe float DeathImpulseRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// StructProperty: ExplosionScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ExplosionScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// ArrayProperty: DeathExplosionSoundArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> DeathExplosionSoundArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// FloatProperty: CrushThreshold
    /// </summary>
    public unsafe float CrushThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// FloatProperty: CrushThresholdZ
    /// </summary>
    public unsafe float CrushThresholdZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// StructProperty: CachedLightMat1234
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor CachedLightMat1234
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// StructProperty: CachedLightMat5678
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor CachedLightMat5678
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// ByteProperty: CachedTankLightsOn
    /// </summary>
    public unsafe byte CachedTankLightsOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_SideCheckDist_Min
    /// </summary>
    public unsafe float PawnCollision_SideCheckDist_Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_SideCheckDist_Max
    /// </summary>
    public unsafe float PawnCollision_SideCheckDist_Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_CosCheck_Front
    /// </summary>
    public unsafe float PawnCollision_CosCheck_Front
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_CosCheck_Side
    /// </summary>
    public unsafe float PawnCollision_CosCheck_Side
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_LookAhead_SpeedMultiplier
    /// </summary>
    public unsafe float PawnCollision_LookAhead_SpeedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_LookAhead_BaseDist
    /// </summary>
    public unsafe float PawnCollision_LookAhead_BaseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_LookAhead_Min
    /// </summary>
    public unsafe float PawnCollision_LookAhead_Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// FloatProperty: PawnCollision_BackAdjustment
    /// </summary>
    public unsafe float PawnCollision_BackAdjustment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ArrayProperty: WhooshBys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FSimpleWhooshBy> WhooshBys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FSimpleWhooshBy>>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// IntProperty: RainMPID
    /// </summary>
    public unsafe int RainMPID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// FloatProperty: LastXrayUpdateTime
    /// </summary>
    public unsafe float LastXrayUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// StructProperty: PreviousObstacleLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PreviousObstacleLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ArrayProperty: LightsMaterialInst
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> LightsMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// StructProperty: WinchAttachLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 WinchAttachLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// IntProperty: ObstacleIndex
    /// </summary>
    public unsafe int ObstacleIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// StructProperty: RoadObstacleExtraBounds
    /// </summary>
    public unsafe System.Numerics.Vector3 RoadObstacleExtraBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// StructProperty: COMOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 COMOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// FloatProperty: MassScale
    /// </summary>
    public unsafe float MassScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// FloatProperty: CarAlarmTime
    /// </summary>
    public unsafe float CarAlarmTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// FloatProperty: CarElectricalOverloadTime
    /// </summary>
    public unsafe float CarElectricalOverloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// FloatProperty: HazardTime
    /// </summary>
    public unsafe float HazardTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// FloatProperty: RoofLightsSignalOffset
    /// </summary>
    public unsafe float RoofLightsSignalOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// NameProperty: InitialAnimName
    /// </summary>
    public unsafe BmSDK.FName InitialAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// FloatProperty: WindscreenCrackValue
    /// </summary>
    public unsafe float WindscreenCrackValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// NameProperty: WindscreenCrackParamName
    /// </summary>
    public unsafe BmSDK.FName WindscreenCrackParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// IntProperty: WindowsMaterialIndex
    /// </summary>
    public unsafe int WindowsMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// FloatProperty: DriversWindowCrackValue
    /// </summary>
    public unsafe float DriversWindowCrackValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// FloatProperty: DriversPassengerWindowCrackValue
    /// </summary>
    public unsafe float DriversPassengerWindowCrackValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// FloatProperty: MolotovFireTime
    /// </summary>
    public unsafe float MolotovFireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// FloatProperty: BurnValuePerSec
    /// </summary>
    public unsafe float BurnValuePerSec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// ArrayProperty: MolotovBurnPoints
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> MolotovBurnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// ArrayProperty: MolotovIntialBurn
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> MolotovIntialBurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// ArrayProperty: MolotovBurns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAbandonedVehicle.FMolotovTimeParam> MolotovBurns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAbandonedVehicle.FMolotovTimeParam>>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// ArrayProperty: RainMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> RainMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// FloatProperty: RainAccumulationAlpha
    /// </summary>
    public unsafe float RainAccumulationAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// FloatProperty: WetnessAccumulationAlpha
    /// </summary>
    public unsafe float WetnessAccumulationAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// NameProperty: RainParameterName
    /// </summary>
    public unsafe BmSDK.FName RainParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// StructProperty: InitialLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 InitialLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// IntProperty: Health
    /// </summary>
    public unsafe int Health
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// FloatProperty: SpawnTime
    /// </summary>
    public unsafe float SpawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// StructProperty: DeathHitLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 DeathHitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// FloatProperty: DamageTimeEMP
    /// </summary>
    public unsafe float DamageTimeEMP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// FloatProperty: ThugDamageOnExplode
    /// </summary>
    public unsafe float ThugDamageOnExplode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// FloatProperty: ThugDamageOnExplodeRadius
    /// </summary>
    public unsafe float ThugDamageOnExplodeRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// FloatProperty: ImpactDamageSpeedThreshold
    /// </summary>
    public unsafe float ImpactDamageSpeedThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// StructProperty: CrushPos
    /// </summary>
    public unsafe System.Numerics.Vector3 CrushPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// StructProperty: CrushNeg
    /// </summary>
    public unsafe System.Numerics.Vector3 CrushNeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// IntProperty: PylonReferences
    /// </summary>
    public unsafe int PylonReferences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// FloatProperty: NavMeshShapeHeightOffset
    /// </summary>
    public unsafe float NavMeshShapeHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// FloatProperty: NavMeshShapeHeight
    /// </summary>
    public unsafe float NavMeshShapeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// FloatProperty: DynamicNavMeshShapeHeightOffset
    /// </summary>
    public unsafe float DynamicNavMeshShapeHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// ArrayProperty: MyNavMeshEdges
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon.FEdgeReference> MyNavMeshEdges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon.FEdgeReference>>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// ArrayProperty: MyObstaclePolys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon.FObstaclePolyPylonPair> MyObstaclePolys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon.FObstaclePolyPylonPair>>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// IntProperty: MaxObstaclePolys
    /// </summary>
    public unsafe int MaxObstaclePolys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// ArrayProperty: CachedNavMeshShape
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> CachedNavMeshShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// StructProperty: CapeCollisionPhysXActor
    /// </summary>
    public unsafe System.IntPtr CapeCollisionPhysXActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// FloatProperty: CurrentXRayAlpha
    /// </summary>
    public unsafe float CurrentXRayAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }
}
