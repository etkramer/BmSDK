#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: Component<br/>
/// (size = 100)
/// (flags = 0)
/// </summary>
public partial class Component : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Component", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Component() { }

    /// <summary>
    /// Constructs a new Component
    /// </summary>
    public Component(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Component Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Component(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: ECollisionFilter
    /// </summary>
    public enum ECollisionFilter
    {
        COF_NoCollision = 0,
        COF_Level = 1,
        COF_LevelGeometry = 2,
        COF_LevelGeometry_BlockWeapons = 3,
        COF_LevelGeometry_BlockAllButWeapons = 4,
        COF_ReinforcedGlass = 5,
        COF_Volume = 6,
        COF_PlayerOnlyVolume = 7,
        COF_StreamingVolume = 8,
        COF_TriggerVolume = 9,
        COF_WaterVolume = 10,
        COF_PredSideRoom = 11,
        COF_AudioVolume = 12,
        COF_BlockingVolume = 13,
        COF_BlockingVolume_Player = 14,
        COF_BlockingVolume_Enemies = 15,
        COF_BlockingVolume_AllCharacters = 16,
        COF_BlockingVolume_Gadgets = 17,
        COF_BlockingVolume_PlayerAndGadgets = 18,
        COF_BlockingVolume_EnemyWeaponsAndLos = 19,
        COF_BlockingVolume_Camera = 20,
        COF_BlockingBolume_Vehicles = 21,
        COF_BlockingBolume_BlockEject = 22,
        COF_BlockingVolume_Audio = 23,
        COF_Mover = 24,
        COF_Mover_BlockWeapons = 25,
        COF_Mover_BlockAllButWeapons = 26,
        COF_Actor = 27,
        COF_PawnCharacter = 28,
        COF_UnPossessedPlayer = 29,
        COF_PawnPlayer = 30,
        COF_PawnPlayerInGrateChute = 31,
        COF_PlayerBlockers = 32,
        COF_Vehicle = 33,
        COF_PlayerVehicle = 34,
        COF_Gadget = 35,
        COF_Projectile = 36,
        COF_Camera = 37,
        COF_VehicleCamera = 38,
        COF_ActorDoesntBlockCamera = 39,
        COF_ActorDoesntBlockVehiceCamera = 40,
        COF_ActorDoesntBlockCameraNorProjectiles = 41,
        COF_FractureMesh = 42,
        COF_FractureTakedown = 43,
        COF_FractureFragileTakedown = 44,
        COF_FractureGlass = 45,
        COF_FractureGlassCeiling = 46,
        COF_FractureFragileGlass = 47,
        COF_HidePoint = 48,
        COF_HidePointWithBatmanOn = 49,
        COF_Wire = 50,
        COF_FloorGrate = 51,
        COF_WallGrate = 52,
        COF_Smoke = 53,
        COF_Trap = 54,
        COF_DestructiblePropDynamic = 55,
        COF_AiScout = 56,
        COF_CombatProxy = 57,
        COF_ProjectileTarget = 58,
        COF_ParticleTouch = 59,
        COF_FootstepOnly = 60,
        COF_ProjectileDetector = 61,
        COF_ActorBlocksAudio = 62,
        COF_BeamVantagePoint = 63,
        COF_TraceAll = 64,
        COF_TraceLevel = 65,
        COF_TraceWorld = 66,
        COF_TraceTerrain = 67,
        COF_TraceActors = 68,
        COF_TracePawns = 69,
        COF_TraceOthers = 70,
        COF_TraceVolumes = 71,
        COF_TracePhysicsVolumes = 72,
        COF_TraceWorldActors = 73,
        COF_TraceWorldOthers = 74,
        COF_TraceWorldMoversOthers = 75,
        COF_TraceWorldMoversVehiclesOthers = 76,
        COF_TraceWorldMoversOthersVolumes = 77,
        COF_TraceShadow = 78,
        COF_TraceClimbable = 79,
        COF_TraceFractureMesh = 80,
        COF_TraceLineOfSight = 81,
        COF_TraceLineOfSightIncSmoke = 82,
        COF_TraceLineOfSightIncGrates = 83,
        COF_TraceLineOfSightIncSmokeAndGrates = 84,
        COF_TraceLineOfSightCanSeeThroughGlassCeilings = 85,
        COF_TraceLaser = 86,
        COF_TraceSmoke = 87,
        COF_TraceSnapToFloor = 88,
        COF_TraceGrappleEnvironment = 89,
        COF_TraceGrapplePlacement = 90,
        COF_TraceRopeObstruction = 91,
        COF_TraceExplosiveGel = 92,
        COF_TraceWaterFeeler = 93,
        COF_TraceRain = 94,
        COF_TracePhysicsGrabber = 95,
        COF_TraceRopeLength = 96,
        COF_TraceSplashDamage = 97,
        COF_TraceDiveThroughWindow = 98,
        COF_TraceExplosiveGelTarget = 99,
        COF_TraceGrappleTarget = 100,
        COF_TraceGrappleSwingTarget = 101,
        COF_TraceParticles = 102,
        COF_TraceParticlesWithPawn = 103,
        COF_TraceCameraHideObjects = 104,
        COF_TraceCameraHideObjectsBatmobile = 105,
        COF_TraceClimbableOthers = 106,
        COF_TraceFlamethrower = 107,
        COF_TraceFootstep = 108,
        COF_TraceCameraFocus = 109,
        COF_TraceWorldVehicles = 110,
        COF_TraceCameraTransition = 111,
        COF_TraceFootCorrection = 112,
        COF_TraceBatmobileEjectHeight = 113,
        COF_TraceBatmobileWheelSprings = 114,
        COF_TraceSpawnVehicleLOS = 115,
        COF_TraceWorldAudio = 116,
        COF_TraceProjectileTargets = 117,
        COF_TraceBatmanLOSGadgets = 118,
        COF_TraceVehicles = 119,
        COF_TraceTankTargetBeam = 120,
        COF_TraceAudioVolumes = 121,
        COF_TraceVehicleSpawnClearArea = 122,
        COF_TraceSniperLaser = 123,
        COF_TraceVehicleWheels = 124,
        COF_TraceDisruptorSniper = 125,
        COF_TraceCanSeeRiddlerPickup = 126,
        COF_MAX = 127,
    }

    /// <summary>
    /// ClassProperty: TemplateOwnerClass
    /// </summary>
    public unsafe BmSDK.Class TemplateOwnerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: TemplateName
    /// </summary>
    public unsafe BmSDK.FName TemplateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
