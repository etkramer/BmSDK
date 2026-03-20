#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_PredatorMusicControl<br/>
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_PredatorMusicControl : BmSDK.Engine.AkActionGlobal_MusicControl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_PredatorMusicControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_PredatorMusicControl() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_PredatorMusicControl
    /// </summary>
    public AkActionGlobal_PredatorMusicControl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_PredatorMusicControl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_PredatorMusicControl(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Predator_Intro
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName Predator_Intro
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: Predator_FirstTD_Silent
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName Predator_FirstTD_Silent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: Predator_FirstTD_Noisy
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName Predator_FirstTD_Noisy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: Predator_Loop
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName Predator_Loop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: Predator_Fail
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName Predator_Fail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: Predator_Success
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName Predator_Success
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ObjectProperty: SpottedSting
    /// </summary>
    public unsafe BmSDK.Engine.AkTriggerName SpottedSting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkTriggerName>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// FloatProperty: Predator_Fail_Timeout
    /// </summary>
    public unsafe float Predator_Fail_Timeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StrProperty: FailFlag
    /// </summary>
    public unsafe BmSDK.FString FailFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: FailOnDeath
    /// </summary>
    public unsafe bool FailOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: IgnoreSpotted
    /// </summary>
    public unsafe bool IgnoreSpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: ReactToOtherPlayerSpotted
    /// </summary>
    public unsafe bool ReactToOtherPlayerSpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: TriggerSuccessOnOnFinaleCamera
    /// </summary>
    public unsafe bool TriggerSuccessOnOnFinaleCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: GoToNoisyIfSpottedDuringIntro
    /// </summary>
    public unsafe bool GoToNoisyIfSpottedDuringIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: DoesNotLerpDownIfNoTakedowns
    /// </summary>
    public unsafe bool DoesNotLerpDownIfNoTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: LerpDownToPreviousAfterSpotted
    /// </summary>
    public unsafe bool LerpDownToPreviousAfterSpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: ClearGlobalsOnSuccessOrFail
    /// </summary>
    public unsafe bool ClearGlobalsOnSuccessOrFail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: m_WasNoisy
    /// </summary>
    public unsafe bool m_WasNoisy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: m_WasFear
    /// </summary>
    public unsafe bool m_WasFear
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: m_CurrentlySpotted
    /// </summary>
    public unsafe bool m_CurrentlySpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: m_PlayerSpotted
    /// </summary>
    public unsafe bool m_PlayerSpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: m_DeactivateDueToSuccess
    /// </summary>
    public unsafe bool m_DeactivateDueToSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: m_CurrentFearTakedown
    /// </summary>
    public unsafe bool m_CurrentFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: MakePredatorGoToMaxOnSpotted
    /// </summary>
    public unsafe bool MakePredatorGoToMaxOnSpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: AllowResetAfterChallenge
    /// </summary>
    public unsafe bool AllowResetAfterChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: BatmanArkhamCityStyleController
    /// </summary>
    public unsafe bool BatmanArkhamCityStyleController
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// FloatProperty: Predator_Success_Timeout
    /// </summary>
    public unsafe float Predator_Success_Timeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StrProperty: SuccessFlag
    /// </summary>
    public unsafe BmSDK.FString SuccessFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// IntProperty: NumberOfPredatorSteps
    /// </summary>
    public unsafe int NumberOfPredatorSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: StepDownTime
    /// </summary>
    public unsafe float StepDownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// FloatProperty: StartLerpTime
    /// </summary>
    public unsafe float StartLerpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: SpottedDownTime
    /// </summary>
    public unsafe float SpottedDownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StructProperty: m_TimeSinceTakedown
    /// </summary>
    public unsafe double m_TimeSinceTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StructProperty: m_TimeSinceSpotted
    /// </summary>
    public unsafe double m_TimeSinceSpotted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: m_TakedownCount
    /// </summary>
    public unsafe int m_TakedownCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: m_LayeredCount
    /// </summary>
    public unsafe int m_LayeredCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// IntProperty: m_LastTargetHash
    /// </summary>
    public unsafe int m_LastTargetHash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// IntProperty: m_LastTakeDownTargetHash
    /// </summary>
    public unsafe int m_LastTakeDownTargetHash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
}
