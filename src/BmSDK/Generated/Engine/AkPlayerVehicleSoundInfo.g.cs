#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkPlayerVehicleSoundInfo<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkPlayerVehicleSoundInfo : BmSDK.Engine.AkVehicleSoundInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkPlayerVehicleSoundInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkPlayerVehicleSoundInfo() { }

    /// <summary>
    /// Constructs a new AkPlayerVehicleSoundInfo
    /// </summary>
    public AkPlayerVehicleSoundInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkPlayerVehicleSoundInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkPlayerVehicleSoundInfo(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: EngineUse
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EngineUse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// ObjectProperty: FreeWheelEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FreeWheelEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// ObjectProperty: ExhaustPops
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExhaustPops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// ObjectProperty: SetGloballySpeedParam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SetGloballySpeedParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// ObjectProperty: OneShotWheelSpinRelease
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OneShotWheelSpinRelease
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// ObjectProperty: TurboStartingEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurboStartingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// ObjectProperty: DumpEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DumpEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// ObjectProperty: SpinParam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpinParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// ObjectProperty: BoostStartEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BoostStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// ObjectProperty: BoostKillEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BoostKillEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// ObjectProperty: EventForLookAheadOnRamp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventForLookAheadOnRamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// ObjectProperty: EventForLookAheadJump
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventForLookAheadJump
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// ObjectProperty: EventForLookAheadLand
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventForLookAheadLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// ObjectProperty: EventForLookAheadActualLand
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventForLookAheadActualLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// ObjectProperty: LimiterParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LimiterParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// ObjectProperty: WheelSpinOnEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WheelSpinOnEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// ObjectProperty: WheelSpinOffEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WheelSpinOffEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// ObjectProperty: DriftOnEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DriftOnEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// ObjectProperty: DriftOffEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DriftOffEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// ObjectProperty: GlobalDriftParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GlobalDriftParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// ObjectProperty: DriftOnState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DriftOnState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// ObjectProperty: WheelSpeedParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WheelSpeedParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// ObjectProperty: CallInLoop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CallInLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }

    /// <summary>
    /// ObjectProperty: CallInSetOff
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CallInSetOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// ObjectProperty: PlayerEjectRotateLoop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerEjectRotateLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// ObjectProperty: CallInState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CallInState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// ObjectProperty: WarmUpTurboDonuts
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WarmUpTurboDonuts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// ObjectProperty: LoopingForceSquealEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LoopingForceSquealEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// ObjectProperty: LoopingForceSquealParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LoopingForceSquealParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }

    /// <summary>
    /// ObjectProperty: RotationParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RotationParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// ObjectProperty: RotationState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RotationState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// ObjectProperty: RotationLoopingEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RotationLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// ObjectProperty: WheelSpinState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WheelSpinState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// ObjectProperty: PursuitToBattleMode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PursuitToBattleMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// ObjectProperty: BattleModeToPursuit
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BattleModeToPursuit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// ObjectProperty: BattleModeForward
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BattleModeForward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// ObjectProperty: BattleModeBackward
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BattleModeBackward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// ObjectProperty: BattleModeLeft
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BattleModeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ObjectProperty: BattleModeRight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BattleModeRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// ObjectProperty: CoolDownEngineTickSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CoolDownEngineTickSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ObjectProperty: EMPParam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EMPParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// FloatProperty: EngineUsePerMinute
    /// </summary>
    public unsafe float EngineUsePerMinute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// FloatProperty: EngineDecayPerMinute
    /// </summary>
    public unsafe float EngineDecayPerMinute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// FloatProperty: EngineUseMaxValue
    /// </summary>
    public unsafe float EngineUseMaxValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }

    /// <summary>
    /// FloatProperty: EngineUseRPMThreshold
    /// </summary>
    public unsafe float EngineUseRPMThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// FloatProperty: MinimumSpeedForExhaust
    /// </summary>
    public unsafe float MinimumSpeedForExhaust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// FloatProperty: MinRPMForExhaustPops
    /// </summary>
    public unsafe float MinRPMForExhaustPops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// FloatProperty: LoadAmountForPops
    /// </summary>
    public unsafe float LoadAmountForPops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// FloatProperty: MinimumExhaustFireTime
    /// </summary>
    public unsafe float MinimumExhaustFireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// BoolProperty: SetGloballyRawSuspensionParam
    /// </summary>
    public unsafe bool SetGloballyRawSuspensionParam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1824) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1824); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1824); }
    }

    /// <summary>
    /// BoolProperty: JumpEndsOnLand
    /// </summary>
    public unsafe bool JumpEndsOnLand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1824) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1824); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1824); }
    }

    /// <summary>
    /// BoolProperty: DisableRotationRPM
    /// </summary>
    public unsafe bool DisableRotationRPM
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1824) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1824); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1824); }
    }

    /// <summary>
    /// FloatProperty: MaximumSpeedForOneShotWheelSpin
    /// </summary>
    public unsafe float MaximumSpeedForOneShotWheelSpin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// FloatProperty: OneShotReleaseDelay
    /// </summary>
    public unsafe float OneShotReleaseDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// FloatProperty: DumpDropThreshold
    /// </summary>
    public unsafe float DumpDropThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// FloatProperty: TurboAttackLagSeconds
    /// </summary>
    public unsafe float TurboAttackLagSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// FloatProperty: TurboDecayLagSeconds
    /// </summary>
    public unsafe float TurboDecayLagSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// FloatProperty: LookAheadOnRampSpeed
    /// </summary>
    public unsafe float LookAheadOnRampSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// FloatProperty: TimeToLookAhead
    /// </summary>
    public unsafe float TimeToLookAhead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeLookAheadAbandoned
    /// </summary>
    public unsafe float TimeBeforeLookAheadAbandoned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// FloatProperty: TimeAfterJumpToEnableLookAhead
    /// </summary>
    public unsafe float TimeAfterJumpToEnableLookAhead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// NameProperty: BoneForLookAheadStart
    /// </summary>
    public unsafe BmSDK.FName BoneForLookAheadStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// FloatProperty: LimiterThreshold
    /// </summary>
    public unsafe float LimiterThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// FloatProperty: LimiterThresholdTime
    /// </summary>
    public unsafe float LimiterThresholdTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// FloatProperty: LimiterRetriggerTimeMin
    /// </summary>
    public unsafe float LimiterRetriggerTimeMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// FloatProperty: LimiterRetriggerTimeMax
    /// </summary>
    public unsafe float LimiterRetriggerTimeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// FloatProperty: LimiterResetTime
    /// </summary>
    public unsafe float LimiterResetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// ArrayProperty: WheelSpinLoopingEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> WheelSpinLoopingEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// ArrayProperty: DriftLoopingEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> DriftLoopingEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// ArrayProperty: SteeringArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> SteeringArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeLFO
    /// </summary>
    public unsafe float TimeBeforeLFO
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// FloatProperty: LFOVariance
    /// </summary>
    public unsafe float LFOVariance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// FloatProperty: LFOTimePeriod
    /// </summary>
    public unsafe float LFOTimePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// ArrayProperty: CallInArrayLoop
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> CallInArrayLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// FloatProperty: BattleModeSpeedAdjust
    /// </summary>
    public unsafe float BattleModeSpeedAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// FloatProperty: BattleModeMagnitude
    /// </summary>
    public unsafe float BattleModeMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// FloatProperty: BattleModeResetMagnitude
    /// </summary>
    public unsafe float BattleModeResetMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// FloatProperty: BattleModeRetriggerTime
    /// </summary>
    public unsafe float BattleModeRetriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// ArrayProperty: OutOfVehicleLoopingEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> OutOfVehicleLoopingEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// ArrayProperty: StartLoopingEventsPursuit
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> StartLoopingEventsPursuit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// ArrayProperty: StartLoopingEventsAltOnly
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> StartLoopingEventsAltOnly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// FloatProperty: LeaveSettleTime
    /// </summary>
    public unsafe float LeaveSettleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// FloatProperty: EnterSettleTime
    /// </summary>
    public unsafe float EnterSettleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }
}
