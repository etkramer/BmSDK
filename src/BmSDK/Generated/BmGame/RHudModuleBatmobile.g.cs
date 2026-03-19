#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleBatmobile<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModuleBatmobile : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleBatmobile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleBatmobile() { }

    /// <summary>
    /// Constructs a new RHudModuleBatmobile
    /// </summary>
    public RHudModuleBatmobile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleBatmobile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleBatmobile(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: DeployedAndActive
    /// </summary>
    public unsafe bool DeployedAndActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: BoostGaugeVisible
    /// </summary>
    public unsafe bool BoostGaugeVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: WinchIsOnTarget
    /// </summary>
    public unsafe bool WinchIsOnTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: WinchMeterVisible
    /// </summary>
    public unsafe bool WinchMeterVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: VirusUploadActive
    /// </summary>
    public unsafe bool VirusUploadActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bHasPassenger
    /// </summary>
    public unsafe bool bHasPassenger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bHasSecondPassenger
    /// </summary>
    public unsafe bool bHasSecondPassenger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bComboOnscreen
    /// </summary>
    public unsafe bool bComboOnscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingHudChange
    /// </summary>
    public unsafe bool PendingHudChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingPrimaryWeapon
    /// </summary>
    public unsafe bool PendingPrimaryWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: CurrentSecondaryWeaponAvailable
    /// </summary>
    public unsafe bool CurrentSecondaryWeaponAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: CurrentOnCoolDown
    /// </summary>
    public unsafe bool CurrentOnCoolDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingSecondaryWeapon
    /// </summary>
    public unsafe bool PendingSecondaryWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingCannonCooldown
    /// </summary>
    public unsafe bool PendingCannonCooldown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingSpecialWeapon
    /// </summary>
    public unsafe bool PendingSpecialWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: BattleModeActive
    /// </summary>
    public unsafe bool BattleModeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: ZoomModeActive
    /// </summary>
    public unsafe bool ZoomModeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingBattleAndZoom
    /// </summary>
    public unsafe bool PendingBattleAndZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: WeaponFeedbackActive
    /// </summary>
    public unsafe bool WeaponFeedbackActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: WeaponFeedbackEffective
    /// </summary>
    public unsafe bool WeaponFeedbackEffective
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: PendingWeaponFeedback
    /// </summary>
    public unsafe bool PendingWeaponFeedback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: SuppressNextChargeIncreaseSound
    /// </summary>
    public unsafe bool SuppressNextChargeIncreaseSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetBoostGauge
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetBoostGauge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetEnemyCount
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetEnemyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetMedalProportion
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetMedalProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetMedalType
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetMedalType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetBatmobileCombo
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetBatmobileCombo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetHealth
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetXpLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetXpLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetWinchMeter
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetWinchMeter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetPrimaryWeapon
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetPrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCannonCooldown
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCannonCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSpecialWeapons
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSpecialWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetBattleAndZoomMode
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetBattleAndZoomMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetWeaponFeedback
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetWeaponFeedback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetTurnAround
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetTurnAround
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetEnergySystem
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetEnergySystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StrProperty: CurrentForensicTrailDisplay
    /// </summary>
    public unsafe BmSDK.FString CurrentForensicTrailDisplay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetClockTimer
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetClockTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetMachineGunAccuracyFrame
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetMachineGunAccuracyFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: BoostLevel
    /// </summary>
    public unsafe int BoostLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// IntProperty: BoostUpgradeLevel
    /// </summary>
    public unsafe int BoostUpgradeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// IntProperty: CurrentEnemyCount
    /// </summary>
    public unsafe int CurrentEnemyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: CurrentMedalProportion
    /// </summary>
    public unsafe float CurrentMedalProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: CurrentMedalIndex
    /// </summary>
    public unsafe int CurrentMedalIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: ComboSecondsForCountdown
    /// </summary>
    public unsafe float ComboSecondsForCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: ComboMultipier
    /// </summary>
    public unsafe int ComboMultipier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: CurrentComboReductionFactor
    /// </summary>
    public unsafe float CurrentComboReductionFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: fCurrentHealthProportion
    /// </summary>
    public unsafe float fCurrentHealthProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: WinchConeAngleDegrees
    /// </summary>
    public unsafe float WinchConeAngleDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: WinchNeedleAngleDegrees
    /// </summary>
    public unsafe float WinchNeedleAngleDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// StrProperty: CurrentPrimaryWeapon
    /// </summary>
    public unsafe BmSDK.FString CurrentPrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// StrProperty: CurrentSecondaryWeapon
    /// </summary>
    public unsafe BmSDK.FString CurrentSecondaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: CurrentCannonCooldown
    /// </summary>
    public unsafe int CurrentCannonCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: SpecialWeaponValue1
    /// </summary>
    public unsafe int SpecialWeaponValue1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// IntProperty: SpecialWeaponValue2
    /// </summary>
    public unsafe int SpecialWeaponValue2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// IntProperty: SpecialWeaponValue3
    /// </summary>
    public unsafe int SpecialWeaponValue3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: WeaponFeedBackTimer
    /// </summary>
    public unsafe float WeaponFeedBackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// IntProperty: TurnaroundTimer
    /// </summary>
    public unsafe int TurnaroundTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: TurnaroundCurrentValue
    /// </summary>
    public unsafe int TurnaroundCurrentValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: CurrentMachineGunAccuracy
    /// </summary>
    public unsafe float CurrentMachineGunAccuracy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// IntProperty: CurrentMachineGunAccuracyFrame
    /// </summary>
    public unsafe int CurrentMachineGunAccuracyFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: ES_NumCharges
    /// </summary>
    public unsafe int ES_NumCharges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// IntProperty: ES_MaxCharges
    /// </summary>
    public unsafe int ES_MaxCharges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: ES_GaugeProportion
    /// </summary>
    public unsafe float ES_GaugeProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: BattleModeOpacity
    /// </summary>
    public unsafe float BattleModeOpacity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }
}
