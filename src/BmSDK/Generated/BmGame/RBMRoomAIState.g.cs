#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMRoomAIState<br/>
/// (flags = 0)
/// </summary>
public partial class RBMRoomAIState : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMRoomAIState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMRoomAIState() { }

    /// <summary>
    /// Constructs a new RBMRoomAIState
    /// </summary>
    public RBMRoomAIState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMRoomAIState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMRoomAIState(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: PreSeedVoiceAssignments
    /// </summary>
    public unsafe void PreSeedVoiceAssignments()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PreSeedVoiceAssignments", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: RegisterThugTakedownFromGrate
    /// </summary>
    public unsafe void RegisterThugTakedownFromGrate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterThugTakedownFromGrate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoStartTimerEvent
    /// </summary>
    public unsafe void DoStartTimerEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DoStartTimerEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AreThugsAwareOfBatmanInBank
    /// </summary>
    public unsafe bool AreThugsAwareOfBatmanInBank()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AreThugsAwareOfBatmanInBank", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FearTakedownChainSuccessfullyCompleted
    /// </summary>
    public unsafe void FearTakedownChainSuccessfullyCompleted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.FearTakedownChainSuccessfullyCompleted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetRoomState
    /// </summary>
    public unsafe void ResetRoomState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ResetRoomState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetCornersUsedForAttack
    /// </summary>
    public unsafe void ResetCornersUsedForAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ResetCornersUsedForAttack", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasCornerBeenUsedForAttack
    /// </summary>
    public unsafe bool HasCornerBeenUsedForAttack(BmSDK.BmGame.RCornerWallMarkerBase CheckCorner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasCornerBeenUsedForAttack", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckCorner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: AddCornerUsedForAttack
    /// </summary>
    public unsafe void AddCornerUsedForAttack(BmSDK.BmGame.RCornerWallMarkerBase NewCorner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AddCornerUsedForAttack", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCorner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFearTakedownFlag
    /// </summary>
    public unsafe BmSDK.FString GetFearTakedownFlag()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetFearTakedownFlag", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetNumberOfRemainingFearTakedownsToNone
    /// </summary>
    public unsafe void ResetNumberOfRemainingFearTakedownsToNone()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ResetNumberOfRemainingFearTakedownsToNone", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetNumberOfRemainingFearTakedownsToFull
    /// </summary>
    public unsafe void ResetNumberOfRemainingFearTakedownsToFull()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ResetNumberOfRemainingFearTakedownsToFull", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoesPlayerHaveEnoughEnergyForAFearTakedown
    /// </summary>
    public unsafe bool DoesPlayerHaveEnoughEnergyForAFearTakedown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DoesPlayerHaveEnoughEnergyForAFearTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetHasDoneManDown
    /// </summary>
    public unsafe void SetHasDoneManDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SetHasDoneManDown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnregisterCasToBeChecked
    /// </summary>
    public unsafe void UnregisterCasToBeChecked(BmSDK.BmGame.RPawnVillain ExCas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.UnregisterCasToBeChecked", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExCas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryCheekyMineRegisterForRepeatTakedownExploitCounter
    /// </summary>
    public unsafe void TryCheekyMineRegisterForRepeatTakedownExploitCounter(BmSDK.BmGame.RAEC_Casualty NewCasAEC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.TryCheekyMineRegisterForRepeatTakedownExploitCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCasAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterCasToBeChecked
    /// </summary>
    public unsafe void RegisterCasToBeChecked(BmSDK.BmGame.RPawnVillain NewCas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterCasToBeChecked", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyLevelScriptingAllCasualtiesFound
    /// </summary>
    public unsafe void NotifyLevelScriptingAllCasualtiesFound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.NotifyLevelScriptingAllCasualtiesFound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyLevelScriptingCasFound
    /// </summary>
    public unsafe void NotifyLevelScriptingCasFound(BmSDK.BmGame.RPawnVillain cas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.NotifyLevelScriptingCasFound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCornerPointVisibility
    /// </summary>
    public unsafe void UpdateCornerPointVisibility()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.UpdateCornerPointVisibility", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: ResetRoomStats
    /// </summary>
    public unsafe void ResetRoomStats()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ResetRoomStats", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPredatorVariationBonus
    /// </summary>
    public unsafe int GetPredatorVariationBonus()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetPredatorVariationBonus", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AddPredatorTakedown
    /// </summary>
    public unsafe void AddPredatorTakedown(BmSDK.BmGame.RGameInfo.EGameAction Action, BmSDK.Engine.Actor Victim)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AddPredatorTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe void PawnDied(BmSDK.BmGame.RPawnVillain DeadPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PawnDied", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetLethalTrapUsage
    /// </summary>
    public unsafe void ResetLethalTrapUsage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ResetLethalTrapUsage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasThugRefusedToUseVoiceSynthesiserLethalTrap
    /// </summary>
    public unsafe bool HasThugRefusedToUseVoiceSynthesiserLethalTrap(BmSDK.BmGame.RBMRoomAIState.VoiceSynthesiserLethalTrap CheckLethalTrap)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasThugRefusedToUseVoiceSynthesiserLethalTrap", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLethalTrap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetThugHasRefusedToUseVoiceSynthesiserLethalTrap
    /// </summary>
    public unsafe void SetThugHasRefusedToUseVoiceSynthesiserLethalTrap(BmSDK.BmGame.RBMRoomAIState.VoiceSynthesiserLethalTrap UsedLethalTrap)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SetThugHasRefusedToUseVoiceSynthesiserLethalTrap", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsedLethalTrap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasThugHasBeenKilledByVoiceSynthesiserLethalTrap
    /// </summary>
    public unsafe bool HasThugHasBeenKilledByVoiceSynthesiserLethalTrap(BmSDK.BmGame.RBMRoomAIState.VoiceSynthesiserLethalTrap CheckLethalTrap)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasThugHasBeenKilledByVoiceSynthesiserLethalTrap", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLethalTrap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetThugHasBeenKilledByVoiceSynthesiserLethalTrap
    /// </summary>
    public unsafe void SetThugHasBeenKilledByVoiceSynthesiserLethalTrap(BmSDK.BmGame.RBMRoomAIState.VoiceSynthesiserLethalTrap UsedLethalTrap)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SetThugHasBeenKilledByVoiceSynthesiserLethalTrap", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsedLethalTrap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: VoiceSynthOrderFinished_PlayRefuse
    /// </summary>
    public unsafe void VoiceSynthOrderFinished_PlayRefuse(bool bInterrupted)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.VoiceSynthOrderFinished_PlayRefuse", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInterrupted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayVoiceSynthesiserInvestigateTargetOrder
    /// </summary>
    public unsafe void PlayVoiceSynthesiserInvestigateTargetOrder(BmSDK.Engine.Actor ThugTarget, BmSDK.Engine.Actor InvestigationTarget, BmSDK.BmGame.RAlertEventCoordinatorBase AEC, BmSDK.BmGame.RPawnVillain NewThugPlayingRefuseOrder = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PlayVoiceSynthesiserInvestigateTargetOrder", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InvestigationTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThugPlayingRefuseOrder, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayVoiceSynthesiserGoToLocationOrder
    /// </summary>
    public unsafe void PlayVoiceSynthesiserGoToLocationOrder(BmSDK.Engine.Actor ThugTarget, BmSDK.BmGame.RAlertEventCoordinatorBase AEC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PlayVoiceSynthesiserGoToLocationOrder", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayVoiceSynthesiserDisabledBroadcast
    /// </summary>
    public unsafe void PlayVoiceSynthesiserDisabledBroadcast(BmSDK.BmGame.RAlertEventCoordinatorBase AEC, bool bEventIsDrivingTiming = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PlayVoiceSynthesiserDisabledBroadcast", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEventIsDrivingTiming, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: VoiceSynthesiserDisabledBroadcastFinished
    /// </summary>
    public unsafe void VoiceSynthesiserDisabledBroadcastFinished(bool bInterrupted)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.VoiceSynthesiserDisabledBroadcastFinished", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInterrupted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetVoiceSynthesiserUseDetected
    /// </summary>
    public unsafe void ResetVoiceSynthesiserUseDetected()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ResetVoiceSynthesiserUseDetected", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCommanderVoiceForVoiceSynthesiser
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState.CommanderVoiceForVoiceSynthesiser GetCommanderVoiceForVoiceSynthesiser()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetCommanderVoiceForVoiceSynthesiser", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState.CommanderVoiceForVoiceSynthesiser>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsSpecialLocationWhereScarecrowOrdersMilitiaInsteadOfArkhamKnight
    /// </summary>
    public unsafe bool IsSpecialLocationWhereScarecrowOrdersMilitiaInsteadOfArkhamKnight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.IsSpecialLocationWhereScarecrowOrdersMilitiaInsteadOfArkhamKnight", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoTacticianResponse_KismetTriggered
    /// </summary>
    public unsafe void DoTacticianResponse_KismetTriggered(BmSDK.BmGame.RGameInfo.AAITakedownType takedownType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DoTacticianResponse_KismetTriggered", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedownType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PickClosestMineableGarg
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint PickClosestMineableGarg(BmSDK.BmGame.RPawn inPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PickClosestMineableGarg", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: PickRandomMineableGarg
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint PickRandomMineableGarg()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PickRandomMineableGarg", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PickRandomResponderPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PickRandomResponderPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PickRandomResponderPawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PickBestResponderPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PickBestResponderPawn(BmSDK.Engine.Actor locActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PickBestResponderPawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(locActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetTargetTunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel GetTargetTunnel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetTargetTunnel", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GrenTunnelAssignmentFound
    /// </summary>
    public unsafe void GrenTunnelAssignmentFound(BmSDK.BmGame.RTunnelFunnel Tunnel, BmSDK.BmGame.RBMPawnAI GrenPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GrenTunnelAssignmentFound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tunnel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrenGrateAssignmentFound
    /// </summary>
    public unsafe void GrenGrateAssignmentFound(BmSDK.BmGame.RTunnelGrateBase Grate, BmSDK.BmGame.RBMPawnAI GrenPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GrenGrateAssignmentFound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Grate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InformRoomThatGrateIsDestroyed
    /// </summary>
    public unsafe void InformRoomThatGrateIsDestroyed(BmSDK.BmGame.RTunnelGrateBase DeadGrate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.InformRoomThatGrateIsDestroyed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadGrate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterGrateToBeDestroyed
    /// </summary>
    public unsafe void RegisterGrateToBeDestroyed(BmSDK.BmGame.RTunnelGrateBase NewGrate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterGrateToBeDestroyed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyCarriedSentryKitDidDisruptorExplosion
    /// </summary>
    public unsafe void NotifyCarriedSentryKitDidDisruptorExplosion(BmSDK.BmGame.RCarriableObjectBagBase bag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.NotifyCarriedSentryKitDidDisruptorExplosion", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SentryKitAssignmentFailed
    /// </summary>
    public unsafe void SentryKitAssignmentFailed(BmSDK.BmGame.RSentryKitAssignmentPicker SKAP)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SentryKitAssignmentFailed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SKAP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SentryKitAssignmentFound
    /// </summary>
    public unsafe void SentryKitAssignmentFound(BmSDK.BmGame.RSentryKitAssignmentPicker SKAP, BmSDK.BmGame.RLootSourceBase ChosenKit)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SentryKitAssignmentFound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SKAP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChosenKit, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleSentryKitAssignment
    /// </summary>
    public unsafe void HandleSentryKitAssignment(BmSDK.BmGame.RSentryGunPlacementPoint TestPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HandleSentryKitAssignment", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBestSentryGunPlacementFor
    /// </summary>
    public unsafe BmSDK.BmGame.RSentryGunPlacementPoint GetBestSentryGunPlacementFor(System.Numerics.Vector3 TestPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetBestSentryGunPlacementFor", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSentryGunPlacementPoint>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: DoVantageMineAssignment
    /// </summary>
    public unsafe void DoVantageMineAssignment(BmSDK.BmGame.RHidePoint Garg, BmSDK.BmGame.RBMPawnAI MinePawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DoVantageMineAssignment", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Garg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinePawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMineArrayIndexForGarg
    /// </summary>
    public unsafe int GetMineArrayIndexForGarg(BmSDK.BmGame.RHidePoint TestGarg)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetMineArrayIndexForGarg", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestGarg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: InformRoomThatGargMineFailed
    /// </summary>
    public unsafe void InformRoomThatGargMineFailed(BmSDK.BmGame.RHidePoint MinedGarg)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.InformRoomThatGargMineFailed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinedGarg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InformRoomThatGargIsMined
    /// </summary>
    public unsafe void InformRoomThatGargIsMined(BmSDK.BmGame.RHidePoint MinedGarg)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.InformRoomThatGargIsMined", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinedGarg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasGargToMineWithNoDestPoints
    /// </summary>
    public unsafe bool HasGargToMineWithNoDestPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasGargToMineWithNoDestPoints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MineAssignmentFailed
    /// </summary>
    public unsafe void MineAssignmentFailed(BmSDK.BmGame.RGargMineAssignmentPicker GMAP)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.MineAssignmentFailed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GMAP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MineAssignmentFound
    /// </summary>
    public unsafe void MineAssignmentFound(BmSDK.BmGame.RGargMineAssignmentPicker GMAP, BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FGargToPoints> NewSmashList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.MineAssignmentFound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GMAP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSmashList, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleVantageMineAssignment
    /// </summary>
    public unsafe void HandleVantageMineAssignment()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HandleVantageMineAssignment", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterVantagePointToBeMined
    /// </summary>
    public unsafe void RegisterVantagePointToBeMined(BmSDK.BmGame.RHidePoint NewTarget, System.Numerics.Vector3 NewRefPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterVantagePointToBeMined", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRefPoint, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FloorMineAssignmentFound
    /// </summary>
    public unsafe void FloorMineAssignmentFound(BmSDK.BmGame.RThugMineablePointFloor MinePoint, BmSDK.BmGame.RBMPawnAI MinePawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.FloorMineAssignmentFound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinePawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisplayDbgAnnouncerMessage
    /// </summary>
    public unsafe void DisplayDbgAnnouncerMessage(BmSDK.FString msg)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DisplayDbgAnnouncerMessage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(msg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNearestThugToPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController GetNearestThugToPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetNearestThugToPlayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoLitePredCalmBark
    /// </summary>
    public unsafe void DoLitePredCalmBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DoLitePredCalmBark", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetLitePredNumLeftFlagValue
    /// </summary>
    public unsafe BmSDK.FString GetLitePredNumLeftFlagValue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetLitePredNumLeftFlagValue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RegisterThrownObject_Pred
    /// </summary>
    public unsafe void RegisterThrownObject_Pred(BmSDK.BmGame.RBMCombatThrownObject_Predator NewThrown)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterThrownObject_Pred", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThrown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TunnelCheckDone
    /// </summary>
    public unsafe void TunnelCheckDone(BmSDK.BmGame.RTunnelFunnel CheckedTunnel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.TunnelCheckDone", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckedTunnel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterTunnelToBeGrenaded
    /// </summary>
    public unsafe void RegisterTunnelToBeGrenaded(BmSDK.BmGame.RTunnelFunnel NewTunnel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterTunnelToBeGrenaded", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTunnel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnregisterMine
    /// </summary>
    public unsafe void UnregisterMine(BmSDK.BmGame.RThugMineBase ExMine)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.UnregisterMine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExMine, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterMine
    /// </summary>
    public unsafe void RegisterMine(BmSDK.BmGame.RThugMineBase NewMine)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterMine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMine, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnFloorMinePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RThugMineablePointFloor_Spawned SpawnFloorMinePoint(System.Numerics.Vector3 mineLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SpawnFloorMinePoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mineLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RThugMineablePointFloor_Spawned>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: RemoveVentMinePoint
    /// </summary>
    public unsafe void RemoveVentMinePoint(BmSDK.BmGame.RThugMineablePointVent ExPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RemoveVentMinePoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddVentMinePoint
    /// </summary>
    public unsafe void AddVentMinePoint(BmSDK.BmGame.RTunnelGrateBase EntryGrate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AddVentMinePoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EntryGrate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterLitePredPatrol
    /// </summary>
    public unsafe void RegisterLitePredPatrol(BmSDK.BmGame.RPatrolPoint_LitePred NewPatrol)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterLitePredPatrol", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPatrol, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideVantagePlayers
    /// </summary>
    public unsafe void HideVantagePlayers()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HideVantagePlayers", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideVantagePlayersWhoAreNotAttackedOrChased
    /// </summary>
    public unsafe void HideVantagePlayersWhoAreNotAttackedOrChased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HideVantagePlayersWhoAreNotAttackedOrChased", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsAnyPlayerBeingAttackedOrChased
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPredAttackState IsAnyPlayerBeingAttackedOrChased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.IsAnyPlayerBeingAttackedOrChased", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPredAttackState>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearBankSpottedSloMoIfAllThugsFinished
    /// </summary>
    public unsafe void ClearBankSpottedSloMoIfAllThugsFinished(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ClearBankSpottedSloMoIfAllThugsFinished", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsInAnAttackState
    /// </summary>
    public unsafe bool IsInAnAttackState(BmSDK.BmGame.RBMBehaviour_BagCarrierBase TestBagCarrierBehaviour)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.IsInAnAttackState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBagCarrierBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TriggerBankLostBMBark
    /// </summary>
    public unsafe void TriggerBankLostBMBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.TriggerBankLostBMBark", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireSightLostEvents
    /// </summary>
    public unsafe void FireSightLostEvents()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.FireSightLostEvents", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForScriptedLastThugEvents
    /// </summary>
    public unsafe void CheckForScriptedLastThugEvents()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.CheckForScriptedLastThugEvents", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckIfWeNeedToFastTrackTannoy
    /// </summary>
    public unsafe void CheckIfWeNeedToFastTrackTannoy()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.CheckIfWeNeedToFastTrackTannoy", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowMagicReload
    /// </summary>
    public unsafe bool AllowMagicReload()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AllowMagicReload", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BackdatedAwarenessToAllVillains
    /// </summary>
    public unsafe void BackdatedAwarenessToAllVillains(BmSDK.Engine.Actor AlertingActor, System.Numerics.Vector3 OldLoc, float BackDateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.BackdatedAwarenessToAllVillains", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlertingActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackDateTime, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNumSentriesAssigned
    /// </summary>
    public unsafe int GetNumSentriesAssigned()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetNumSentriesAssigned", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DecKnownTakedownCount
    /// </summary>
    public unsafe void DecKnownTakedownCount(BmSDK.BmGame.RPawnVillain Victim)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DecKnownTakedownCount", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncKnownTakedownCount
    /// </summary>
    public unsafe void IncKnownTakedownCount(BmSDK.BmGame.RPawnVillain Victim)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.IncKnownTakedownCount", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasThugsDoingGrateWatch
    /// </summary>
    public unsafe bool HasThugsDoingGrateWatch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasThugsDoingGrateWatch", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanStartPlantBomb
    /// </summary>
    public unsafe bool CanStartPlantBomb()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.CanStartPlantBomb", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RoomNeedsMinesPlacing
    /// </summary>
    public unsafe bool RoomNeedsMinesPlacing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RoomNeedsMinesPlacing", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasVantageMineLayer
    /// </summary>
    public unsafe bool HasVantageMineLayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasVantageMineLayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasMineLayer
    /// </summary>
    public unsafe bool HasMineLayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasMineLayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasConciousMedic
    /// </summary>
    public unsafe bool HasConciousMedic()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasConciousMedic", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasActiveMedicWhoIsNotTrapped
    /// </summary>
    public unsafe bool HasActiveMedicWhoIsNotTrapped()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasActiveMedicWhoIsNotTrapped", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasActiveMedic
    /// </summary>
    public unsafe bool HasActiveMedic()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasActiveMedic", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasActiveMiniDrone
    /// </summary>
    public unsafe bool HasActiveMiniDrone()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasActiveMiniDrone", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasRoomGotMoreThanOneActiveStealthThug
    /// </summary>
    public unsafe bool HasRoomGotMoreThanOneActiveStealthThug()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasRoomGotMoreThanOneActiveStealthThug", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasRoomGotActiveStealthThug
    /// </summary>
    public unsafe bool HasRoomGotActiveStealthThug()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasRoomGotActiveStealthThug", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasRoomGotActiveLeader
    /// </summary>
    public unsafe bool HasRoomGotActiveLeader()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasRoomGotActiveLeader", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNonStaticHostileCount
    /// </summary>
    public unsafe int GetNonStaticHostileCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetNonStaticHostileCount", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AllThugsAreIncapacitated
    /// </summary>
    public unsafe bool AllThugsAreIncapacitated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AllThugsAreIncapacitated", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHostileCount
    /// </summary>
    public unsafe int GetHostileCount(bool bIgnoreDeadPawns = default, bool bIncludePotentialRevives = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetHostileCount", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDeadPawns, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludePotentialRevives, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CancelAllUnfinishedManDowns
    /// </summary>
    public unsafe void CancelAllUnfinishedManDowns()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.CancelAllUnfinishedManDowns", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RespondToOutOfControlMinidroneExplode
    /// </summary>
    public unsafe void RespondToOutOfControlMinidroneExplode(BmSDK.BmGame.RPawnVillain DroneConPawn, System.Numerics.Vector3 ExplodeLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RespondToOutOfControlMinidroneExplode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DroneConPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExplodeLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RespondToBatmobileFiring
    /// </summary>
    public unsafe void RespondToBatmobileFiring(System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RespondToBatmobileFiring", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RespondToDisruptedJammer
    /// </summary>
    public unsafe void RespondToDisruptedJammer(BmSDK.BmGame.RPawnVillainGunBase DisruptedJammerThug)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RespondToDisruptedJammer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisruptedJammerThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SendFearLevelChange
    /// </summary>
    public unsafe void SendFearLevelChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SendFearLevelChange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PropagateRoomwideAlert
    /// </summary>
    public unsafe void PropagateRoomwideAlert()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PropagateRoomwideAlert", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRoomFlags
    /// </summary>
    public unsafe void SetRoomFlags(out BmSDK.BmGame.RBarkFlagBase FB, BmSDK.BmGame.RPawnPlayer PP = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SetRoomFlags", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PP, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FB = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: HasDoneManyManDowns
    /// </summary>
    public unsafe bool HasDoneManyManDowns()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.HasDoneManyManDowns", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TakedownLevelIsOneShortOfTerrified
    /// </summary>
    public unsafe bool TakedownLevelIsOneShortOfTerrified()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.TakedownLevelIsOneShortOfTerrified", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetFearLevelAsFlagVal
    /// </summary>
    public unsafe BmSDK.FName GetFearLevelAsFlagVal(BmSDK.BmGame.RBMRoomAIState.VillainFearLevel TestFearLevel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetFearLevelAsFlagVal", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestFearLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetFearLevelAsString
    /// </summary>
    public unsafe BmSDK.FString GetFearLevelAsString(BmSDK.BmGame.RBMRoomAIState.VillainFearLevel TestFearLevel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetFearLevelAsString", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestFearLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetTakedownFearLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState.VillainFearLevel GetTakedownFearLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetTakedownFearLevel", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState.VillainFearLevel>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTerrifiedLevel
    /// </summary>
    public unsafe int GetTerrifiedLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetTerrifiedLevel", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsRoomAlmostTerrified
    /// </summary>
    public unsafe bool IsRoomAlmostTerrified()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.IsRoomAlmostTerrified", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AllTakedownsDiscovered
    /// </summary>
    public unsafe bool AllTakedownsDiscovered()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AllTakedownsDiscovered", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TotalKnownTakedownCount
    /// </summary>
    public unsafe int TotalKnownTakedownCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.TotalKnownTakedownCount", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MakeNervous
    /// </summary>
    public unsafe void MakeNervous()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.MakeNervous", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PrepareNewWave
    /// </summary>
    public unsafe void PrepareNewWave()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PrepareNewWave", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryTriggerAbandonDroneEvent
    /// </summary>
    public unsafe void TryTriggerAbandonDroneEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.TryTriggerAbandonDroneEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryTriggerMissingThugCheckin
    /// </summary>
    public unsafe void TryTriggerMissingThugCheckin(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.TryTriggerMissingThugCheckin", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ThisThugShouldSmashGenerators
    /// </summary>
    public unsafe bool ThisThugShouldSmashGenerators(BmSDK.BmGame.RBMPawnAI TestPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ThisThugShouldSmashGenerators", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsThisGrateMarkedForDestruction
    /// </summary>
    public unsafe bool IsThisGrateMarkedForDestruction(BmSDK.BmGame.RTunnelGrateBase TestGrate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.IsThisGrateMarkedForDestruction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestGrate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetUnassignedSentryKits
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootSourceBase> GetUnassignedSentryKits()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetUnassignedSentryKits", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootSourceBase>>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetIntactGratesUsedForTakedowns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> GetIntactGratesUsedForTakedowns()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetIntactGratesUsedForTakedowns", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTargetGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GetTargetGrate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetTargetGrate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetIncendiaryGrenadePawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GetIncendiaryGrenadePawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetIncendiaryGrenadePawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCurrentVantageMineTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint GetCurrentVantageMineTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetCurrentVantageMineTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsWantedForVantageMineCounterExploit
    /// </summary>
    public unsafe bool IsWantedForVantageMineCounterExploit(BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.IsWantedForVantageMineCounterExploit", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsWantedForAAIOrder
    /// </summary>
    public unsafe bool IsWantedForAAIOrder(BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.IsWantedForAAIOrder", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CullExcessGuns
    /// </summary>
    public unsafe void CullExcessGuns()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.CullExcessGuns", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AreThugsKnockedOutByGooMines
    /// </summary>
    public unsafe bool AreThugsKnockedOutByGooMines()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AreThugsKnockedOutByGooMines", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AreThugsAwareofGooMines
    /// </summary>
    public unsafe bool AreThugsAwareofGooMines()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AreThugsAwareofGooMines", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RegisterGooMineTakedowns
    /// </summary>
    public unsafe void RegisterGooMineTakedowns(int NumToAdd)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterGooMineTakedowns", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumToAdd, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DetectiveModeDetectorTriggerLatch
    /// </summary>
    public unsafe void DetectiveModeDetectorTriggerLatch(BmSDK.BmGame.RPawnVillain latchingPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DetectiveModeDetectorTriggerLatch", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(latchingPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DetectiveModeDetectorTriggerAlert
    /// </summary>
    public unsafe void DetectiveModeDetectorTriggerAlert(BmSDK.BmGame.RPawnVillain alertTriggerer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DetectiveModeDetectorTriggerAlert", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(alertTriggerer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AssignDetectiveModeDetectorPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain AssignDetectiveModeDetectorPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AssignDetectiveModeDetectorPawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetChapterScaledDMDIncreaseRate
    /// </summary>
    public unsafe float GetChapterScaledDMDIncreaseRate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetChapterScaledDMDIncreaseRate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckLOSFromDMDLatchLocToCurrentPlayerLoc
    /// </summary>
    public unsafe bool CheckLOSFromDMDLatchLocToCurrentPlayerLoc()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.CheckLOSFromDMDLatchLocToCurrentPlayerLoc", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateDetectiveModeDetection
    /// </summary>
    public unsafe void UpdateDetectiveModeDetection(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.UpdateDetectiveModeDetection", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryTriggerAdaptiveMinePlacement
    /// </summary>
    public unsafe void TryTriggerAdaptiveMinePlacement()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.TryTriggerAdaptiveMinePlacement", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DynamicallyActivateMinePointsNearLocation
    /// </summary>
    public unsafe int DynamicallyActivateMinePointsNearLocation(System.Numerics.Vector3 Loc, int numToActivate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.DynamicallyActivateMinePointsNearLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(numToActivate, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: UnregisterActiveMinePoint
    /// </summary>
    public unsafe void UnregisterActiveMinePoint(BmSDK.BmGame.RThugMineablePointBase OldPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.UnregisterActiveMinePoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterActiveMinePoint
    /// </summary>
    public unsafe void RegisterActiveMinePoint(BmSDK.BmGame.RThugMineablePointBase NewPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterActiveMinePoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPotentialMineLayingLocations
    /// </summary>
    public unsafe int GetPotentialMineLayingLocations(System.Numerics.Vector3 casLoc, float Radius, int numRequired, BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FLocationToAvoidMining> locationsToAvoid, out BmSDK.TArray<System.Numerics.Vector3> validLocations)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetPotentialMineLayingLocations", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(casLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(numRequired, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(locationsToAvoid, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        validLocations = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 52);
    }

    /// <summary>
    /// Function: SelectBestMineLocation
    /// </summary>
    public unsafe int SelectBestMineLocation(BmSDK.TArray<System.Numerics.Vector3> candidateLocations, BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FLocationToAvoidMining> locationsToAvoid)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SelectBestMineLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(candidateLocations, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(locationsToAvoid, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: CheckSnapMineLocation
    /// </summary>
    public unsafe bool CheckSnapMineLocation(System.Numerics.Vector3 InLoc, out System.Numerics.Vector3 snappedLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.CheckSnapMineLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        snappedLoc = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: AddLocationForAdaptiveMinePlacement
    /// </summary>
    public unsafe void AddLocationForAdaptiveMinePlacement(System.Numerics.Vector3 mineLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AddLocationForAdaptiveMinePlacement", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mineLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGrateVis
    /// </summary>
    public unsafe void UpdateGrateVis(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.UpdateGrateVis", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ASyncGameInfoTick
    /// </summary>
    public unsafe void ASyncGameInfoTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ASyncGameInfoTick", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreASyncGameInfoTick
    /// </summary>
    public unsafe void PreASyncGameInfoTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.PreASyncGameInfoTick", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateVertVisibility
    /// </summary>
    public unsafe void UpdateVertVisibility()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.UpdateVertVisibility", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: ClearAllThugsFrom
    /// </summary>
    public unsafe void ClearAllThugsFrom(BmSDK.BmGame.RGuardVolume GVol)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ClearAllThugsFrom", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GVol, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForTooManyStaticGuards
    /// </summary>
    public unsafe void CheckForTooManyStaticGuards()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.CheckForTooManyStaticGuards", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterPreDeplyedSentryGun
    /// </summary>
    public unsafe void RegisterPreDeplyedSentryGun(BmSDK.BmGame.RSentryGunBase NewSentryGun)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterPreDeplyedSentryGun", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSentryGun, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterSentryGunPlacePoint
    /// </summary>
    public unsafe void RegisterSentryGunPlacePoint(BmSDK.BmGame.RSentryGunPlacementPoint NewPlacePoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterSentryGunPlacePoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlacePoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterSentryGunDispenser
    /// </summary>
    public unsafe void RegisterSentryGunDispenser(BmSDK.BmGame.RLootSourceBase NewDispenser)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterSentryGunDispenser", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDispenser, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterActiveGuardVol
    /// </summary>
    public unsafe void RegisterActiveGuardVol(BmSDK.BmGame.RGuardVolume NewVol)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterActiveGuardVol", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVol, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterPreventNonMedicManDownVolume
    /// </summary>
    public unsafe void RegisterPreventNonMedicManDownVolume(BmSDK.BmGame.RPreventNonMedicManDownVolume NewPNMMDVol)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterPreventNonMedicManDownVolume", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPNMMDVol, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnregisterSpotable
    /// </summary>
    public unsafe void UnregisterSpotable(BmSDK.Engine.Actor ExSpotable)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.UnregisterSpotable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExSpotable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterSpotable
    /// </summary>
    public unsafe void RegisterSpotable(BmSDK.Engine.Actor NewSpotable)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterSpotable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpotable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterDeadGuy
    /// </summary>
    public unsafe void RegisterDeadGuy()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterDeadGuy", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: JammerRestored
    /// </summary>
    public unsafe void JammerRestored()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.JammerRestored", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: JammerDisabled
    /// </summary>
    public unsafe void JammerDisabled()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.JammerDisabled", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNumSnipers
    /// </summary>
    public unsafe int GetNumSnipers()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetNumSnipers", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RemoveSniper
    /// </summary>
    public unsafe void RemoveSniper(BmSDK.BmGame.RPawnVillain OldSniper)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RemoveSniper", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldSniper, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddSniper
    /// </summary>
    public unsafe void AddSniper(BmSDK.BmGame.RPawnVillain NewSniper)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AddSniper", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSniper, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RoomCompleted
    /// </summary>
    public unsafe void RoomCompleted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RoomCompleted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveController
    /// </summary>
    public unsafe void RemoveController(BmSDK.BmGame.RBMAIController ToRemove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RemoveController", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddController
    /// </summary>
    public unsafe void AddController(BmSDK.BmGame.RBMAIController NewController)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AddController", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterPlayerPawn
    /// </summary>
    public unsafe void RegisterPlayerPawn(BmSDK.BmGame.RPawnPlayer NewPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterPlayerPawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitAEC
    /// </summary>
    public unsafe void InitAEC()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.InitAEC", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe void Init()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.Init", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldThugsSearchGratesForStagg
    /// </summary>
    public unsafe bool ShouldThugsSearchGratesForStagg()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.ShouldThugsSearchGratesForStagg", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateMineAndArmbandFX
    /// </summary>
    public unsafe void UpdateMineAndArmbandFX(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.UpdateMineAndArmbandFX", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: RemoveKnownNavObstacle
    /// </summary>
    public unsafe void RemoveKnownNavObstacle(BmSDK.Engine.NavMeshObstacle Obstacle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RemoveKnownNavObstacle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obstacle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddKnownNavObstacle
    /// </summary>
    public unsafe void AddKnownNavObstacle(BmSDK.Engine.NavMeshObstacle Obstacle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AddKnownNavObstacle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obstacle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindMaxLevelScriptRootsAllowed
    /// </summary>
    public unsafe int FindMaxLevelScriptRootsAllowed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.FindMaxLevelScriptRootsAllowed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindNumLevelScriptRootsAssigned
    /// </summary>
    public unsafe int FindNumLevelScriptRootsAssigned()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.FindNumLevelScriptRootsAssigned", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetMaxLevelScriptingInstances
    /// </summary>
    public unsafe void SetMaxLevelScriptingInstances(int val, bool bAlsoRespectDefaultMaximumRule, bool bUnassignImmediately)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.SetMaxLevelScriptingInstances", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(val, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlsoRespectDefaultMaximumRule, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnassignImmediately, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AreBagCarriersAttacking
    /// </summary>
    public unsafe bool AreBagCarriersAttacking()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.AreBagCarriersAttacking", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetClosestDistanceToBagCarrierDropoff
    /// </summary>
    public unsafe float GetClosestDistanceToBagCarrierDropoff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.GetClosestDistanceToBagCarrierDropoff", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RegisterLockinVolume
    /// </summary>
    public unsafe void RegisterLockinVolume(BmSDK.BmGame.RLockinVolume NewVolume)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterLockinVolume", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVolume, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterLevelScriptRoot
    /// </summary>
    public unsafe void RegisterLevelScriptRoot(BmSDK.BmGame.RSeqEvent_LevelScripting NewRoot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.RegisterLevelScriptRoot", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRoot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Cleanup
    /// </summary>
    public unsafe void Cleanup()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMRoomAIState.Cleanup", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FLocationToAvoidMining
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FLocationToAvoidMining
    {
        /// <summary>
        /// StructProperty: Loc
        /// </summary>
        public unsafe System.Numerics.Vector3 Loc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: minDistToMine
        /// </summary>
        public unsafe float minDistToMine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: locType
        /// </summary>
        public unsafe BmSDK.BmGame.RBMRoomAIState.LocationToAvoidMiningType locType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState.LocationToAvoidMiningType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: LocationToAvoidMiningType
    /// </summary>
    public enum LocationToAvoidMiningType
    {
        LTAMT_Unset = 0,
        LTAMT_ActiveMine = 1,
        LTAMT_FutureMine = 2,
        LTAMT_Body = 3,
        LTAMT_Grate = 4,
        LTAMT_MAX = 5,
    }

    /// <summary>
    /// Enum: VoiceSynthesiserLethalTrap
    /// </summary>
    public enum VoiceSynthesiserLethalTrap
    {
        VSLT_None = 0,
        VSLT_GunCrate = 1,
        VSLT_SentryGun = 2,
        VSLT_FuelCell = 3,
        VSLT_Generator = 4,
        VSLT_Mine = 5,
        VSLT_MAX = 6,
    }

    /// <summary>
    /// Struct: FGuardVolAssignmentTracker
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FGuardVolAssignmentTracker
    {
        /// <summary>
        /// ObjectProperty: Vol
        /// </summary>
        public unsafe BmSDK.BmGame.RGuardVolume Vol
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGuardVolume>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: AssigneeList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillainGunBase> AssigneeList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillainGunBase>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FTakedownGroup
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FTakedownGroup
    {
        /// <summary>
        /// ArrayProperty: GroupActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GroupActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: VillainFearLevel
    /// </summary>
    public enum VillainFearLevel
    {
        VFL_Cocky = 0,
        VFL_Nervous = 1,
        VFL_Terrified = 2,
        VFL_MAX = 3,
    }

    /// <summary>
    /// Struct: FGargToPoints
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FGargToPoints
    {
        /// <summary>
        /// ObjectProperty: Garg
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint Garg
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: AssignID
        /// </summary>
        public unsafe int AssignID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: RefPoint
        /// </summary>
        public unsafe System.Numerics.Vector3 RefPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: DestList
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> DestList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: CommanderVoiceForVoiceSynthesiser
    /// </summary>
    public enum CommanderVoiceForVoiceSynthesiser
    {
        CVFVS_ArkhamKnight = 0,
        CVFVS_HarleyQuinn = 1,
        CVFVS_Scarecrow = 2,
        CVFVS_Deathstroke = 3,
        CVFVS_RandomThugDude = 4,
        CVFVS_MAX = 5,
    }

    /// <summary>
    /// ArrayProperty: SpotableList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SpotableList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: Snipers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> Snipers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: TargetPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer TargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: ThugPlayingRefuseOrder
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain ThugPlayingRefuseOrder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: RefuseOrderAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorBase RefuseOrderAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorBase>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: MineAssign
    /// </summary>
    public unsafe BmSDK.BmGame.RGargMineAssignmentPicker MineAssign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGargMineAssignmentPicker>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: GargSmashPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GargSmashPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: TargetGarg
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint TargetGarg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: GrateGrenadePawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GrateGrenadePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: TargetGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase TargetGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ObjectProperty: GeneratorSmashPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GeneratorSmashPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: SentryKitAssign
    /// </summary>
    public unsafe BmSDK.BmGame.RSentryKitAssignmentPicker SentryKitAssign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSentryKitAssignmentPicker>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ObjectProperty: BarkCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBarkCoordinator BarkCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBarkCoordinator>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ObjectProperty: BarkGroupContext
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkGroupContext_Pred BarkGroupContext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkGroupContext_Pred>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ObjectProperty: CoordinatorParent
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Parent CoordinatorParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Parent>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ObjectProperty: TargetTunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel TargetTunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: TunnelGrenadePawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI TunnelGrenadePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: CornerPointInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass CornerPointInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: DMD_AEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_DetectiveModeDetector_Group DMD_AEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_DetectiveModeDetector_Group>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: DMDClaimedBy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain DMDClaimedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: DMDLatchedFullBy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain DMDLatchedFullBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ObjectProperty: BagCarrierDialogueAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_BagCarrierDialogue BagCarrierDialogueAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_BagCarrierDialogue>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ObjectProperty: DroneAbandonAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_AbandonDrone DroneAbandonAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_AbandonDrone>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: PanicLevel
    /// </summary>
    public unsafe int PanicLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: PanicReasonText
    /// </summary>
    public unsafe BmSDK.FString PanicReasonText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// FloatProperty: LastUpdateTime
    /// </summary>
    public unsafe float LastUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// BoolProperty: bBatmanSeen
    /// </summary>
    public unsafe bool bBatmanSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bBatmanSeenInVantage
    /// </summary>
    public unsafe bool bBatmanSeenInVantage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneManDown
    /// </summary>
    public unsafe bool bHasDoneManDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneGunStartle
    /// </summary>
    public unsafe bool bHasDoneGunStartle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHasSeenBatarangedExtinguisher
    /// </summary>
    public unsafe bool bHasSeenBatarangedExtinguisher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bVoiceSynthUseDetected
    /// </summary>
    public unsafe bool bVoiceSynthUseDetected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForCommanderToStopSpeakingToPlayVoiceSynthesiserDisabledMessage
    /// </summary>
    public unsafe bool bWaitingForCommanderToStopSpeakingToPlayVoiceSynthesiserDisabledMessage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHasStartedMissingThugCheckin
    /// </summary>
    public unsafe bool bHasStartedMissingThugCheckin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bShotInRoom
    /// </summary>
    public unsafe bool bShotInRoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bPlayerTookDamage
    /// </summary>
    public unsafe bool bPlayerTookDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bLastIsNoisy
    /// </summary>
    public unsafe bool bLastIsNoisy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bAllowARChallengesWhilePredatorActive
    /// </summary>
    public unsafe bool bAllowARChallengesWhilePredatorActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bSmashGenerators
    /// </summary>
    public unsafe bool bSmashGenerators
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bDoneBreakout
    /// </summary>
    public unsafe bool bDoneBreakout
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bCachedSightLostSeqEvents
    /// </summary>
    public unsafe bool bCachedSightLostSeqEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bPlayedMineDisabledBark
    /// </summary>
    public unsafe bool bPlayedMineDisabledBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bPlayedOddManOutBark
    /// </summary>
    public unsafe bool bPlayedOddManOutBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bFireSeenWhenSightLevelDecays
    /// </summary>
    public unsafe bool bFireSeenWhenSightLevelDecays
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bHostagePreviouslyTaken
    /// </summary>
    public unsafe bool bHostagePreviouslyTaken
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bCanLockDoors
    /// </summary>
    public unsafe bool bCanLockDoors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bSilentTakedownTakenPlace
    /// </summary>
    public unsafe bool bSilentTakedownTakenPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bLedgeTakedownTakenPlace
    /// </summary>
    public unsafe bool bLedgeTakedownTakenPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bVeryWeakWallTakedownTakenPlace
    /// </summary>
    public unsafe bool bVeryWeakWallTakedownTakenPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bThugHasBeenRevived
    /// </summary>
    public unsafe bool bThugHasBeenRevived
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bDetectiveModeOnAndDetectable
    /// </summary>
    public unsafe bool bDetectiveModeOnAndDetectable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bNoDMD
    /// </summary>
    public unsafe bool bNoDMD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: doneDMDAlertSinceLatch
    /// </summary>
    public unsafe bool doneDMDAlertSinceLatch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bAlsoRespectDefaultMaxLevelScriptingRules
    /// </summary>
    public unsafe bool bAlsoRespectDefaultMaxLevelScriptingRules
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bUnassignFromLevelScriptingImmediately
    /// </summary>
    public unsafe bool bUnassignFromLevelScriptingImmediately
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bBreakThugsOutOfBagCarrier
    /// </summary>
    public unsafe bool bBreakThugsOutOfBagCarrier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bBankBodySeen
    /// </summary>
    public unsafe bool bBankBodySeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bNextChatAboutCash
    /// </summary>
    public unsafe bool bNextChatAboutCash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bPlayedBankExitBark
    /// </summary>
    public unsafe bool bPlayedBankExitBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDrawMineLayingDebug
    /// </summary>
    public unsafe bool bDrawMineLayingDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bMiniDroneUsedInRoom
    /// </summary>
    public unsafe bool bMiniDroneUsedInRoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bThugNoticedDroneScanBefore
    /// </summary>
    public unsafe bool bThugNoticedDroneScanBefore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bScarecrowImpliedThreatToThugs
    /// </summary>
    public unsafe bool bScarecrowImpliedThreatToThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDoneSpecialAAIIntro
    /// </summary>
    public unsafe bool bDoneSpecialAAIIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bSeenThugEatenByPlant
    /// </summary>
    public unsafe bool bSeenThugEatenByPlant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDoneClockTowerCH9SpecialVoiceSynthAck
    /// </summary>
    public unsafe bool bDoneClockTowerCH9SpecialVoiceSynthAck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDontPropagateRoomAlert
    /// </summary>
    public unsafe bool bDontPropagateRoomAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bMilitiaPresent
    /// </summary>
    public unsafe bool bMilitiaPresent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bGangPresent
    /// </summary>
    public unsafe bool bGangPresent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bBankDoneSpottedSlomo
    /// </summary>
    public unsafe bool bBankDoneSpottedSlomo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: RegisteredPredatorStart
    /// </summary>
    public unsafe bool RegisteredPredatorStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bMoneyHasBeenDumped
    /// </summary>
    public unsafe bool bMoneyHasBeenDumped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDoneStartTimerEvent
    /// </summary>
    public unsafe bool bDoneStartTimerEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: KnownTakedownCount
    /// </summary>
    public unsafe int KnownTakedownCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// IntProperty: HostileCount
    /// </summary>
    public unsafe int HostileCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// IntProperty: NumCasualtiesWhenSwitchedToFullPred
    /// </summary>
    public unsafe int NumCasualtiesWhenSwitchedToFullPred
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// IntProperty: MaxHostileCount
    /// </summary>
    public unsafe int MaxHostileCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StructProperty: XPInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FPredatorXPInfo XPInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FPredatorXPInfo>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: MissingCheckinDialogueDelay
    /// </summary>
    public unsafe float MissingCheckinDialogueDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: ControllerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIController> ControllerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIController>>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// IntProperty: IntimidationTakedownsPerformed
    /// </summary>
    public unsafe int IntimidationTakedownsPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// IntProperty: iNumberOfFearTakedownChainsCompleted
    /// </summary>
    public unsafe int iNumberOfFearTakedownChainsCompleted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: DeadThugs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> DeadThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// IntProperty: NumSilentTakedowns
    /// </summary>
    public unsafe int NumSilentTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: ActiveJammerCount
    /// </summary>
    public unsafe int ActiveJammerCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// IntProperty: CurrentID
    /// </summary>
    public unsafe int CurrentID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ArrayProperty: GargsToBeMinedList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FGargToPoints> GargsToBeMinedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FGargToPoints>>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StructProperty: TargetGargRefPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetGargRefPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ArrayProperty: IntactGratesUsedForTakedowns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> IntactGratesUsedForTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: CurrentSentryAssignChance
    /// </summary>
    public unsafe float CurrentSentryAssignChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ByteProperty: FearLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState.VillainFearLevel FearLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState.VillainFearLevel>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: GuardBarkTimer
    /// </summary>
    public unsafe float GuardBarkTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: RandMaxTerrified
    /// </summary>
    public unsafe int RandMaxTerrified
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastReloadBark
    /// </summary>
    public unsafe float TimeSinceLastReloadBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenReloadBarks
    /// </summary>
    public unsafe float MinTimeBetweenReloadBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ArrayProperty: SeenSeqEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> SeenSeqEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ArrayProperty: GrateToMine
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RThugMineablePointVent> GrateToMine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RThugMineablePointVent>>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ArrayProperty: ActiveMinePointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RThugMineablePointBase> ActiveMinePointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RThugMineablePointBase>>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ArrayProperty: ActiveMines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RThugMineBase> ActiveMines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RThugMineBase>>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: TunnelToGrenadeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelFunnel> TunnelToGrenadeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelFunnel>>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ArrayProperty: SentryGunThatNeedsPlacingList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryGunPlacementPoint> SentryGunThatNeedsPlacingList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryGunPlacementPoint>>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ArrayProperty: ThrownObjectList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject_Predator> ThrownObjectList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject_Predator>>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ArrayProperty: VantageCheckHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHidePoint> VantageCheckHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHidePoint>>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: LastThermalCheckBarkTime
    /// </summary>
    public unsafe float LastThermalCheckBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: LastCornerExitBarkTime
    /// </summary>
    public unsafe float LastCornerExitBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: LastMineSafeReactionBarkTime
    /// </summary>
    public unsafe float LastMineSafeReactionBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: LastPairedStopMoveTime
    /// </summary>
    public unsafe float LastPairedStopMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: LastLedgeSearchBarkTime
    /// </summary>
    public unsafe float LastLedgeSearchBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: LastGrateSearchBarkTime
    /// </summary>
    public unsafe float LastGrateSearchBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: LastFinishGuardPerimBarkTime
    /// </summary>
    public unsafe float LastFinishGuardPerimBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: PNMMDVolList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPreventNonMedicManDownVolume> PNMMDVolList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPreventNonMedicManDownVolume>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ArrayProperty: ActiveGuardVolList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGuardVolume> ActiveGuardVolList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGuardVolume>>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ArrayProperty: SentryGunDispenserList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootSourceBase> SentryGunDispenserList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootSourceBase>>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ArrayProperty: SentryGunPlacePointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryGunPlacementPoint> SentryGunPlacePointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryGunPlacementPoint>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: PreDeployedSentryGuns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryGunBase> PreDeployedSentryGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryGunBase>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: PatrolList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPatrolPoint_LitePred> PatrolList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPatrolPoint_LitePred>>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: LiteAlertTime
    /// </summary>
    public unsafe float LiteAlertTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: ValidTakedownActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> ValidTakedownActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ArrayProperty: ValidTakedownNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ValidTakedownNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ArrayProperty: SilentTakedownActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> SilentTakedownActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ArrayProperty: TakedownGroups
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FTakedownGroup> TakedownGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMRoomAIState.FTakedownGroup>>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ArrayProperty: TakedownsPerformed
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> TakedownsPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ArrayProperty: RewardThresholds
    /// </summary>
    public unsafe BmSDK.TArray<int> RewardThresholds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ArrayProperty: CornersUsedForAttacks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCornerWallMarkerBase> CornersUsedForAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCornerWallMarkerBase>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
    /// <summary>
    /// IntProperty: takedownResponseAnnouncementTally
    /// </summary>
    public unsafe int takedownResponseAnnouncementTally_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Initial
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Initial_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_Repeat
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_Repeat_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }
    /// <summary>
    /// NameProperty: takedownResponseBarkFlags_ThugRecover
    /// </summary>
    public unsafe BmSDK.FName takedownResponseBarkFlags_ThugRecover_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// IntProperty: numGrateTakedownsTakenPlace
    /// </summary>
    public unsafe int numGrateTakedownsTakenPlace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// IntProperty: NumGooMineTakedowns
    /// </summary>
    public unsafe int NumGooMineTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: lastPairedCornerVariantTime
    /// </summary>
    public unsafe float lastPairedCornerVariantTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// ArrayProperty: KnownNavMeshObstacles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavMeshObstacle> KnownNavMeshObstacles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavMeshObstacle>>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: DMDProportion
    /// </summary>
    public unsafe float DMDProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// FloatProperty: DMDDecayRate
    /// </summary>
    public unsafe float DMDDecayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: DMDIncreaseRate
    /// </summary>
    public unsafe float DMDIncreaseRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// FloatProperty: DMD_HUDWarnThreshold
    /// </summary>
    public unsafe float DMD_HUDWarnThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: timeTillCanAssignDMD
    /// </summary>
    public unsafe float timeTillCanAssignDMD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// FloatProperty: dmdAssignmentInterval
    /// </summary>
    public unsafe float dmdAssignmentInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// StructProperty: DMDLatchPlayerLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 DMDLatchPlayerLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// StructProperty: lastDMDAlertLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 lastDMDAlertLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// IntProperty: maxLevelScriptingInstances
    /// </summary>
    public unsafe int maxLevelScriptingInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: TimeSincePreviousLastStand
    /// </summary>
    public unsafe float TimeSincePreviousLastStand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenLastStands
    /// </summary>
    public unsafe float TimeBetweenLastStands
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: lastBankChatTime
    /// </summary>
    public unsafe float lastBankChatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// FloatProperty: bankChatInterval
    /// </summary>
    public unsafe float bankChatInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// FloatProperty: lastBankBodyDialogueTime
    /// </summary>
    public unsafe float lastBankBodyDialogueTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// FloatProperty: lastBMLostDialogueTime
    /// </summary>
    public unsafe float lastBMLostDialogueTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ArrayProperty: LevelScriptRootList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqEvent_LevelScripting> LevelScriptRootList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqEvent_LevelScripting>>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ArrayProperty: LockinVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLockinVolume> LockinVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLockinVolume>>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// ArrayProperty: CasualtiesToBeCheckedList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> CasualtiesToBeCheckedList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// ArrayProperty: locationsForAdaptiveMinePlacement
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> locationsForAdaptiveMinePlacement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: iNumberOfFearTakedownsAvailable
    /// </summary>
    public unsafe int iNumberOfFearTakedownsAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// IntProperty: iMaximumNumberOfFearTakedowns
    /// </summary>
    public unsafe int iMaximumNumberOfFearTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// FloatProperty: LastDroneScanBarkTime
    /// </summary>
    public unsafe float LastDroneScanBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// FloatProperty: lastDMDUpdateTime
    /// </summary>
    public unsafe float lastDMDUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }
    /// <summary>
    /// IntProperty: UsedVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int UsedVoiceSynthesiserLethalTraps_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }
    /// <summary>
    /// IntProperty: ThugHasRefusedToUseVoiceSynthesiserLethalTraps
    /// </summary>
    public unsafe int ThugHasRefusedToUseVoiceSynthesiserLethalTraps_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// IntProperty: CurrNavMeshVertUpdaterID
    /// </summary>
    public unsafe int CurrNavMeshVertUpdaterID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: lastAssignToMinePlacementDialogueTime
    /// </summary>
    public unsafe float lastAssignToMinePlacementDialogueTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: lastRepeatBatarangHitTime
    /// </summary>
    public unsafe float lastRepeatBatarangHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: LastPlantBombTime
    /// </summary>
    public unsafe float LastPlantBombTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// ArrayProperty: PotentialSpottedSloMoTarget
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> PotentialSpottedSloMoTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: BankFirstPotentialSloMoTargetTime
    /// </summary>
    public unsafe float BankFirstPotentialSloMoTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// FloatProperty: BankDoneSpottedSlomoLatch
    /// </summary>
    public unsafe float BankDoneSpottedSlomoLatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// FloatProperty: LastSearchUDestSpecialCaseTime
    /// </summary>
    public unsafe float LastSearchUDestSpecialCaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// FloatProperty: LastStealthThugLineTime
    /// </summary>
    public unsafe float LastStealthThugLineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// IntProperty: AlertToMineLayersInFrames
    /// </summary>
    public unsafe int AlertToMineLayersInFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// FloatProperty: lastFearTakedownChainCompletionTime
    /// </summary>
    public unsafe float lastFearTakedownChainCompletionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// IntProperty: NumThugsTakenDownFromGrates
    /// </summary>
    public unsafe int NumThugsTakenDownFromGrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }
}
