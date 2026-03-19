#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_PenguinCarChase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_PenguinCarChase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_PenguinCarChase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_PenguinCarChase() { }

    /// <summary>
    /// Constructs a new RSeqAct_PenguinCarChase
    /// </summary>
    public RSeqAct_PenguinCarChase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_PenguinCarChase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_PenguinCarChase(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bRunning
    /// </summary>
    public unsafe bool bRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bAwareOfPlayer
    /// </summary>
    public unsafe bool bAwareOfPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bAbandonmentCriteriaCurrentlyMet
    /// </summary>
    public unsafe bool bAbandonmentCriteriaCurrentlyMet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bFleeing
    /// </summary>
    public unsafe bool bFleeing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bPlayerInVehicle
    /// </summary>
    public unsafe bool bPlayerInVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bSuspendedExceptHUD
    /// </summary>
    public unsafe bool bSuspendedExceptHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bSpawnedPassengers
    /// </summary>
    public unsafe bool bSpawnedPassengers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: prevCarCountsAsVisible
    /// </summary>
    public unsafe bool prevCarCountsAsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bForceStopFleeing
    /// </summary>
    public unsafe bool bForceStopFleeing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: Car
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Car
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ObjectProperty: Driver
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Driver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ObjectProperty: Passenger
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Passenger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ObjectProperty: CarVehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CarVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ObjectProperty: BoxMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BoxMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ObjectProperty: forensicsDevice
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT forensicsDevice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ComponentProperty: SimCarNPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SimCarNPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// IntProperty: CurrentLane
    /// </summary>
    public unsafe int CurrentLane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// FloatProperty: NextLaneSwapDelay
    /// </summary>
    public unsafe float NextLaneSwapDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: SpookedAudioTimer
    /// </summary>
    public unsafe float SpookedAudioTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// FloatProperty: viewConeAngle
    /// </summary>
    public unsafe float viewConeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: awareOfBMBLRange
    /// </summary>
    public unsafe float awareOfBMBLRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// FloatProperty: minDist2D
    /// </summary>
    public unsafe float minDist2D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// FloatProperty: minDistZ
    /// </summary>
    public unsafe float minDistZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// FloatProperty: maxDist2D
    /// </summary>
    public unsafe float maxDist2D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// FloatProperty: minFleeTime
    /// </summary>
    public unsafe float minFleeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// FloatProperty: introFleeTime
    /// </summary>
    public unsafe float introFleeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// FloatProperty: fUntrackedAndOutOfSightTimeThreshold
    /// </summary>
    public unsafe float fUntrackedAndOutOfSightTimeThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// FloatProperty: fleeTimeRemaining
    /// </summary>
    public unsafe float fleeTimeRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: playerDist2D
    /// </summary>
    public unsafe float playerDist2D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: playerDistZ
    /// </summary>
    public unsafe float playerDistZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: throttleScaleNear
    /// </summary>
    public unsafe float throttleScaleNear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: throttleScaleFar
    /// </summary>
    public unsafe float throttleScaleFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// FloatProperty: throttleScaleNearDist
    /// </summary>
    public unsafe float throttleScaleNearDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: throttleScaleFarDist
    /// </summary>
    public unsafe float throttleScaleFarDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: distanceProportion
    /// </summary>
    public unsafe float distanceProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: SpeedScale
    /// </summary>
    public unsafe float SpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: TimeStarted
    /// </summary>
    public unsafe float TimeStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StructProperty: boxSpawnOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT boxSpawnOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// FloatProperty: boxSpawnIntervalMin
    /// </summary>
    public unsafe float boxSpawnIntervalMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// FloatProperty: boxSpawnIntervalMax
    /// </summary>
    public unsafe float boxSpawnIntervalMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// FloatProperty: boxSpawnMinVanSpeed
    /// </summary>
    public unsafe float boxSpawnMinVanSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: boxLifeTime
    /// </summary>
    public unsafe float boxLifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: maxBoxes
    /// </summary>
    public unsafe int maxBoxes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: nextBoxSpawnTime
    /// </summary>
    public unsafe float nextBoxSpawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: droppedBoxes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> droppedBoxes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: prevLosLockon
    /// </summary>
    public unsafe float prevLosLockon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// FloatProperty: lowLOSThreshold
    /// </summary>
    public unsafe float lowLOSThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: StartedRunningTime
    /// </summary>
    public unsafe float StartedRunningTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }
}
