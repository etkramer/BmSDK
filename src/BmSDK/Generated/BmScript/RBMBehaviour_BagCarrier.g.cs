#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_BagCarrier<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_BagCarrier : BmSDK.BmGame.RBMBehaviour_BagCarrierBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_BagCarrier", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_BagCarrier() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_BagCarrier
    /// </summary>
    public RBMBehaviour_BagCarrier(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_BagCarrier Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_BagCarrier(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: allPickUpPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> allPickUpPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ArrayProperty: allDropOffPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> allDropOffPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: ExitPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExitPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: currPickupPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT currPickupPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: currDropOffPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT currDropOffPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: ShootAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShootAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: GrateTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrateTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: introAnimRefPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT introAnimRefPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: OverridingPickUpPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverridingPickUpPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: OverridingDropOffPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverridingDropOffPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDebug
    /// </summary>
    public unsafe bool bDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bChasePlayer
    /// </summary>
    public unsafe bool bChasePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bFinishedPickingUp
    /// </summary>
    public unsafe bool bFinishedPickingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bHasLootingIdleAnim
    /// </summary>
    public unsafe bool bHasLootingIdleAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bHasLootingOutAnim
    /// </summary>
    public unsafe bool bHasLootingOutAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bGotLootPoints
    /// </summary>
    public unsafe bool bGotLootPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bStartedShooting
    /// </summary>
    public unsafe bool bStartedShooting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bRandomPickupPointSelection
    /// </summary>
    public unsafe bool bRandomPickupPointSelection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bForceFirstPickupPointToBeNonRandom
    /// </summary>
    public unsafe bool bForceFirstPickupPointToBeNonRandom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bChosenPickupPointSinceActivation
    /// </summary>
    public unsafe bool bChosenPickupPointSinceActivation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bPlayIntroAnim
    /// </summary>
    public unsafe bool bPlayIntroAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bEnterFromRight
    /// </summary>
    public unsafe bool bEnterFromRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bPlayedIntroAnim
    /// </summary>
    public unsafe bool bPlayedIntroAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredIntroAnimFinishedOutput
    /// </summary>
    public unsafe bool bTriggeredIntroAnimFinishedOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: inPlaceForGrateGrenadeThrow
    /// </summary>
    public unsafe bool inPlaceForGrateGrenadeThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bagVFXActive
    /// </summary>
    public unsafe bool bagVFXActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bUseAlternateDropoffAnim
    /// </summary>
    public unsafe bool bUseAlternateDropoffAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: cachedDestinationIsWaypoint
    /// </summary>
    public unsafe bool cachedDestinationIsWaypoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bNeverUseWaypoints
    /// </summary>
    public unsafe bool bNeverUseWaypoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bTempDontUseWaypoints
    /// </summary>
    public unsafe bool bTempDontUseWaypoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawWaypoints
    /// </summary>
    public unsafe bool bDbgDrawWaypoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bSpawnedBag
    /// </summary>
    public unsafe bool bSpawnedBag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bLastAmbientDialogueWasAboutCash
    /// </summary>
    public unsafe bool bLastAmbientDialogueWasAboutCash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bHasEverBeenInterrupted
    /// </summary>
    public unsafe bool bHasEverBeenInterrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bDonePostInterruptRoomwideAlert
    /// </summary>
    public unsafe bool bDonePostInterruptRoomwideAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bRequestedLadderFreePath
    /// </summary>
    public unsafe bool bRequestedLadderFreePath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// StructProperty: transID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT transID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// FloatProperty: timeSinceRepathCheck
    /// </summary>
    public unsafe float timeSinceRepathCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: TimeTillOverlay
    /// </summary>
    public unsafe float TimeTillOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: timeBetweenOverlaysMin
    /// </summary>
    public unsafe float timeBetweenOverlaysMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: timeBetweenOverlaysMax
    /// </summary>
    public unsafe float timeBetweenOverlaysMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: TimeSpentPickingUp
    /// </summary>
    public unsafe float TimeSpentPickingUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: pickupDuration
    /// </summary>
    public unsafe float pickupDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: aimAtGrateStartTime
    /// </summary>
    public unsafe float aimAtGrateStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: aimAtGrateDuration
    /// </summary>
    public unsafe float aimAtGrateDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// StructProperty: cachedDropoffDestination
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT cachedDropoffDestination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: nextWaypointIndex
    /// </summary>
    public unsafe int nextWaypointIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: LastHUDTimerDrawTime
    /// </summary>
    public unsafe float LastHUDTimerDrawTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// StructProperty: pickupFromFloorAnimStartLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT pickupFromFloorAnimStartLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: PostCheatChaseStartTime
    /// </summary>
    public unsafe float PostCheatChaseStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ByteProperty: interactDirection
    /// </summary>
    public unsafe byte interactDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ByteProperty: FuturePathElevation
    /// </summary>
    public unsafe byte FuturePathElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 865); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 865); }
    }

    /// <summary>
    /// StructProperty: FuturePathAimPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FuturePathAimPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }
}
