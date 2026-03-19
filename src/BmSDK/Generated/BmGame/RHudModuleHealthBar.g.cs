#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleHealthBar<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModuleHealthBar : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleHealthBar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleHealthBar() { }

    /// <summary>
    /// Constructs a new RHudModuleHealthBar
    /// </summary>
    public RHudModuleHealthBar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleHealthBar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleHealthBar(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Cached_SetHealthLevel
    /// </summary>
    public unsafe BmSDK.FString Cached_SetHealthLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: Cached_ShakeHealthBar
    /// </summary>
    public unsafe BmSDK.FString Cached_ShakeHealthBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StrProperty: Cached_SetHealthBarVisible
    /// </summary>
    public unsafe BmSDK.FString Cached_SetHealthBarVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StrProperty: Cached_SetXpLevel
    /// </summary>
    public unsafe BmSDK.FString Cached_SetXpLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StrProperty: Cached_SetArmourLevel
    /// </summary>
    public unsafe BmSDK.FString Cached_SetArmourLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StrProperty: Cached_SetArmourMaxima
    /// </summary>
    public unsafe BmSDK.FString Cached_SetArmourMaxima
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StrProperty: Cached_SetCombo
    /// </summary>
    public unsafe BmSDK.FString Cached_SetCombo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: Cached_SetComboChallenge
    /// </summary>
    public unsafe BmSDK.FString Cached_SetComboChallenge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: Cached_ShowCriticalMessage
    /// </summary>
    public unsafe BmSDK.FString Cached_ShowCriticalMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: Cached_SetAdrenaline
    /// </summary>
    public unsafe BmSDK.FString Cached_SetAdrenaline
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StrProperty: Cached_SetDualPlayCombo
    /// </summary>
    public unsafe BmSDK.FString Cached_SetDualPlayCombo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StrProperty: Cached_SetBatmobileTakedownPercentage
    /// </summary>
    public unsafe BmSDK.FString Cached_SetBatmobileTakedownPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StrProperty: Cached_SetFearTakedownLevel
    /// </summary>
    public unsafe BmSDK.FString Cached_SetFearTakedownLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StrProperty: Cached_ShakeFearTakedownText
    /// </summary>
    public unsafe BmSDK.FString Cached_ShakeFearTakedownText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StrProperty: Cached_ShowDualCombatSlots
    /// </summary>
    public unsafe BmSDK.FString Cached_ShowDualCombatSlots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// BoolProperty: bHealthBarRequested
    /// </summary>
    public unsafe bool bHealthBarRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bXpBarRequested
    /// </summary>
    public unsafe bool bXpBarRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bCurrentlyVisible
    /// </summary>
    public unsafe bool bCurrentlyVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bPostCombatBreakdownVisible
    /// </summary>
    public unsafe bool bPostCombatBreakdownVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bJokerfied
    /// </summary>
    public unsafe bool bJokerfied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bKillingJoker
    /// </summary>
    public unsafe bool bKillingJoker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: suppress_healthbar
    /// </summary>
    public unsafe bool suppress_healthbar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: FlashHudWhenWounded
    /// </summary>
    public unsafe bool FlashHudWhenWounded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: ArmourInitialised
    /// </summary>
    public unsafe bool ArmourInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: fCurrentHealthProportion
    /// </summary>
    public unsafe float fCurrentHealthProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: fCurrentAdrenalineProportion
    /// </summary>
    public unsafe float fCurrentAdrenalineProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: DualPlayAbilityLevel
    /// </summary>
    public unsafe int DualPlayAbilityLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// IntProperty: DualPlayValueOutOf75
    /// </summary>
    public unsafe int DualPlayValueOutOf75
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: BatmobileTakedownLevel
    /// </summary>
    public unsafe int BatmobileTakedownLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: CurrentFearTakedownLevel
    /// </summary>
    public unsafe int CurrentFearTakedownLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// IntProperty: DualCombatSlots
    /// </summary>
    public unsafe int DualCombatSlots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// IntProperty: ArmourSlotsMelee
    /// </summary>
    public unsafe int ArmourSlotsMelee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: ArmourSlotsBallistic
    /// </summary>
    public unsafe int ArmourSlotsBallistic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }
}
