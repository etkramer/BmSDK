#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleLocalRadar<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModuleLocalRadar : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleLocalRadar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleLocalRadar() { }

    /// <summary>
    /// Constructs a new RHudModuleLocalRadar
    /// </summary>
    public RHudModuleLocalRadar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleLocalRadar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleLocalRadar(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: DeployedAndActive
    /// </summary>
    public unsafe bool DeployedAndActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: CurrentLockonCritical
    /// </summary>
    public unsafe bool CurrentLockonCritical
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: CurrentHealthCritical
    /// </summary>
    public unsafe bool CurrentHealthCritical
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: InBatmobile
    /// </summary>
    public unsafe bool InBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: VehicleTrackingIsActive
    /// </summary>
    public unsafe bool VehicleTrackingIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: RootSonarIsActive
    /// </summary>
    public unsafe bool RootSonarIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: HeavyTankTrackingIsActive
    /// </summary>
    public unsafe bool HeavyTankTrackingIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: BatmobileRevDisplayActive
    /// </summary>
    public unsafe bool BatmobileRevDisplayActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: FlashRadarVisible
    /// </summary>
    public unsafe bool FlashRadarVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: FlashHeavyTanksVisible
    /// </summary>
    public unsafe bool FlashHeavyTanksVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: RootsPermanentlyVisible
    /// </summary>
    public unsafe bool RootsPermanentlyVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpdateTargetPosition
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpdateTargetPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetLockonValue
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetLockonValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetStationaryLockonValue
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetStationaryLockonValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetHealthValue
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetHealthValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_PushTrackedActorsToFlash
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_PushTrackedActorsToFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetPlayerPosition
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetPlayerPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_DoPulse
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_DoPulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StrProperty: CachedVariable_HeavyTankDetailArray
    /// </summary>
    public unsafe BmSDK.FString CachedVariable_HeavyTankDetailArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StrProperty: CachedVariable_TaggedVehicleDetailArray
    /// </summary>
    public unsafe BmSDK.FString CachedVariable_TaggedVehicleDetailArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ObjectProperty: FlashConsolidatedDataArray
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlashConsolidatedDataArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// FloatProperty: CurrentLockOn
    /// </summary>
    public unsafe float CurrentLockOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: CurrentHealth
    /// </summary>
    public unsafe float CurrentHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StrProperty: CurrentHealthTitle
    /// </summary>
    public unsafe BmSDK.FString CurrentHealthTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: RadarRange
    /// </summary>
    public unsafe float RadarRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadarRange
    /// </summary>
    public unsafe float HeavyTankRadarRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: RadarRangeInverse
    /// </summary>
    public unsafe float RadarRangeInverse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadarRangeInverse
    /// </summary>
    public unsafe float HeavyTankRadarRangeInverse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StrProperty: CurrentRootNetwork
    /// </summary>
    public unsafe BmSDK.FString CurrentRootNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ArrayProperty: HeavyTankDetailArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> HeavyTankDetailArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: HeavyTankDetailArrayCopy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> HeavyTankDetailArrayCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// IntProperty: NumChangedTanks
    /// </summary>
    public unsafe int NumChangedTanks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ArrayProperty: HeavyTankDetailObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> HeavyTankDetailObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadiusPositionX
    /// </summary>
    public unsafe float HeavyTankRadiusPositionX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadiusPositionY
    /// </summary>
    public unsafe float HeavyTankRadiusPositionY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: HeavyTankRadiusScale
    /// </summary>
    public unsafe float HeavyTankRadiusScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ArrayProperty: TaggedVehicleDetailArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> TaggedVehicleDetailArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: NumTaggedVehiclePoints
    /// </summary>
    public unsafe int NumTaggedVehiclePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: RandomAngleArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> RandomAngleArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: RandomDistanceArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RandomDistanceArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: FakeTankFrameCounter
    /// </summary>
    public unsafe int FakeTankFrameCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// IntProperty: FakeTankFrameInterval
    /// </summary>
    public unsafe int FakeTankFrameInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// IntProperty: FakeTankNumTanks
    /// </summary>
    public unsafe int FakeTankNumTanks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: NumHeavyTanksInWorld
    /// </summary>
    public unsafe int NumHeavyTanksInWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// IntProperty: NumHeavyTanksLastFrame
    /// </summary>
    public unsafe int NumHeavyTanksLastFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: NumCobraTanksInWorld
    /// </summary>
    public unsafe int NumCobraTanksInWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: NumCobraTanksLastFrame
    /// </summary>
    public unsafe int NumCobraTanksLastFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }
}
