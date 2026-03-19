#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_CombatMusicControl<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_CombatMusicControl : BmSDK.Engine.AkActionGlobal_MusicControl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_CombatMusicControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_CombatMusicControl() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_CombatMusicControl
    /// </summary>
    public AkActionGlobal_CombatMusicControl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_CombatMusicControl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_CombatMusicControl(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MusicStateOverOrOnValue
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MusicStateOverOrOnValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: MusicStateUnderValue
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MusicStateUnderValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: CombatSuccess
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: CombatFail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatFail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: ValueToChangeToCombat
    /// </summary>
    public unsafe float ValueToChangeToCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// FloatProperty: CombatSuccessTimeout
    /// </summary>
    public unsafe float CombatSuccessTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// StrProperty: SuccessGlobalFlag
    /// </summary>
    public unsafe BmSDK.FString SuccessGlobalFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// FloatProperty: CombatFailTimeout
    /// </summary>
    public unsafe float CombatFailTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StrProperty: FailGlobalFlag
    /// </summary>
    public unsafe BmSDK.FString FailGlobalFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: FailOnDeath
    /// </summary>
    public unsafe bool FailOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: TriggerSuccessOnOnFinaleCamera
    /// </summary>
    public unsafe bool TriggerSuccessOnOnFinaleCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: VehicleCombat
    /// </summary>
    public unsafe bool VehicleCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: ClearGlobalsOnSuccessOrFail
    /// </summary>
    public unsafe bool ClearGlobalsOnSuccessOrFail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: KeepCheckingCombatWhilstUnderOne
    /// </summary>
    public unsafe bool KeepCheckingCombatWhilstUnderOne
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: m_DeactivateDueToSuccess
    /// </summary>
    public unsafe bool m_DeactivateDueToSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: m_CurrentFearTakedown
    /// </summary>
    public unsafe bool m_CurrentFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: AllowResetAfterChallenge
    /// </summary>
    public unsafe bool AllowResetAfterChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: EnteredCombatFact
    /// </summary>
    public unsafe BmSDK.FString EnteredCombatFact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenSamePawnDeath
    /// </summary>
    public unsafe float TimeBetweenSamePawnDeath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeDeathsRegisterAfterCombatStarts
    /// </summary>
    public unsafe float TimeBeforeDeathsRegisterAfterCombatStarts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ArrayProperty: CombatValueTable
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> CombatValueTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// FloatProperty: CurrentCombatValue
    /// </summary>
    public unsafe float CurrentCombatValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: PawnsDead
    /// </summary>
    public unsafe int PawnsDead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StructProperty: m_LastPawnDeath
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT m_LastPawnDeath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// IntProperty: m_LastPawnThatDied
    /// </summary>
    public unsafe int m_LastPawnThatDied
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// StructProperty: m_InitialStart
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT m_InitialStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// Struct: FCombatGroups
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FCombatGroups
    {
        /// <summary>
        /// IntProperty: NumberOfPawnsDead
        /// </summary>
        public unsafe int NumberOfPawnsDead
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: ValueToSetCombat
        /// </summary>
        public unsafe float ValueToSetCombat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
