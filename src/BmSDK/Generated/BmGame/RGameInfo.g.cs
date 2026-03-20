#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameInfo<br/>
/// (flags = 0)
/// </summary>
public partial class RGameInfo : BmSDK.BmGame.RGameInfoBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameInfo() { }

    /// <summary>
    /// Constructs a new RGameInfo
    /// </summary>
    public RGameInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: TriggerAllEventsOfClass
    /// </summary>
    public unsafe void TriggerAllEventsOfClass(BmSDK.Class EventClass, BmSDK.Engine.Actor InInstigator = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TriggerAllEventsOfClass", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInstigator, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Hack_FixupMissingBundleNames
    /// </summary>
    public unsafe void Hack_FixupMissingBundleNames()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Hack_FixupMissingBundleNames", true);
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
    /// Function: HydraSyncWBRewards
    /// </summary>
    public unsafe void HydraSyncWBRewards()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HydraSyncWBRewards", true);
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
    /// Function: GetAvailableBAKRewards
    /// </summary>
    public unsafe void GetAvailableBAKRewards(out BmSDK.TArray<BmSDK.FString> Rewards)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetAvailableBAKRewards", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Rewards = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: IsPawnRunningTowards
    /// </summary>
    public unsafe bool IsPawnRunningTowards(BmSDK.Engine.Pawn TestPawn, System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsPawnRunningTowards", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: OnDifficultyChanged
    /// </summary>
    public unsafe void OnDifficultyChanged(int NewDifficulty)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.OnDifficultyChanged", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDifficulty, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetEnvironmentObjectsForChallengeMode
    /// </summary>
    public unsafe void ResetEnvironmentObjectsForChallengeMode(bool bChallengeMode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ResetEnvironmentObjectsForChallengeMode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreMapSwitchResetEnvironmentObjectsForChallengeMode
    /// </summary>
    public unsafe void PreMapSwitchResetEnvironmentObjectsForChallengeMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PreMapSwitchResetEnvironmentObjectsForChallengeMode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPlatformTag
    /// </summary>
    public unsafe BmSDK.FString GetPlatformTag()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlatformTag", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPlatformStr
    /// </summary>
    public unsafe BmSDK.FString GetPlatformStr()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlatformStr", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLanguageCode
    /// </summary>
    public unsafe BmSDK.FString GetLanguageCode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLanguageCode", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetRegionCode
    /// </summary>
    public unsafe BmSDK.FString GetRegionCode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetRegionCode", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsBMBLInRange
    /// </summary>
    public unsafe bool IsBMBLInRange(System.Numerics.Vector3 InLoc, float Range)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsBMBLInRange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Range, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CheckObjectiveActive
    /// </summary>
    public unsafe bool CheckObjectiveActive(BmSDK.FString StringToCheck)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CheckObjectiveActive", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringToCheck, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: SetCurrentObjectiveString
    /// </summary>
    public unsafe void SetCurrentObjectiveString(BmSDK.FString NewObjective)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetCurrentObjectiveString", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewObjective, paramsPtr + 0);
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
    /// Function: PylonLoaded
    /// </summary>
    public unsafe void PylonLoaded(BmSDK.Engine.Pylon NewPylon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PylonLoaded", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPylon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCheatCodeValue
    /// </summary>
    public unsafe void SetCheatCodeValue(BmSDK.BmGame.RGameInfo.ECheatCode Id, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetCheatCodeValue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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
    /// Function: GetCheatCodeValue
    /// </summary>
    public unsafe int GetCheatCodeValue(BmSDK.BmGame.RGameInfo.ECheatCode Id)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetCheatCodeValue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: RemoveDeadVehiclesForExittingCity
    /// </summary>
    public unsafe void RemoveDeadVehiclesForExittingCity()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RemoveDeadVehiclesForExittingCity", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveAllDeadVehicles
    /// </summary>
    public unsafe void RemoveAllDeadVehicles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RemoveAllDeadVehicles", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveDeadVehicle
    /// </summary>
    public unsafe void RemoveDeadVehicle(BmSDK.BmGame.RDeadVehicle Vehicle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RemoveDeadVehicle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDeadVehicle
    /// </summary>
    public unsafe void AddDeadVehicle(BmSDK.BmGame.RDeadVehicle Vehicle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AddDeadVehicle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveVehicle
    /// </summary>
    public unsafe void RemoveVehicle(BmSDK.BmGame.RVehicle Vehicle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RemoveVehicle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddVehicle
    /// </summary>
    public unsafe void AddVehicle(BmSDK.BmGame.RVehicle Vehicle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AddVehicle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AlertAllNearbyThugsToBM
    /// </summary>
    public unsafe void AlertAllNearbyThugsToBM(System.Numerics.Vector3 alertLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AlertAllNearbyThugsToBM", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(alertLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TickInitVehiclesDeferred
    /// </summary>
    public unsafe void TickInitVehiclesDeferred()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TickInitVehiclesDeferred", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveAbandonedVehicleFromDeferredInitList
    /// </summary>
    public unsafe void RemoveAbandonedVehicleFromDeferredInitList(BmSDK.BmGame.RAbandonedVehicle Abandoned)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RemoveAbandonedVehicleFromDeferredInitList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Abandoned, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddAbandonedVehicleToDeferredInitList
    /// </summary>
    public unsafe void AddAbandonedVehicleToDeferredInitList(BmSDK.BmGame.RAbandonedVehicle Abandoned)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AddAbandonedVehicleToDeferredInitList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Abandoned, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TickSpawnVehiclePassengerDeferred
    /// </summary>
    public unsafe void TickSpawnVehiclePassengerDeferred()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TickSpawnVehiclePassengerDeferred", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasAnyVehiclePassengersToSpawn
    /// </summary>
    public unsafe bool HasAnyVehiclePassengersToSpawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HasAnyVehiclePassengersToSpawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasAnyVehiclesToSpawn
    /// </summary>
    public unsafe bool HasAnyVehiclesToSpawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HasAnyVehiclesToSpawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnVehiclePassengerDeferred
    /// </summary>
    public unsafe void SpawnVehiclePassengerDeferred(BmSDK.BmGame.RVehicleNPC Vehicle, int PassengerIndex, BmSDK.BmGame.RBmPawnSpawner Spawner, BmSDK.BmGame.RVehicleScenario Scenario = default, int ScenarioVehicleIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SpawnVehiclePassengerDeferred", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PassengerIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spawner, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scenario, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScenarioVehicleIndex, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnVehicleScenarioDeferred
    /// </summary>
    public unsafe void SpawnVehicleScenarioDeferred(BmSDK.BmGame.RVehicleScenario Scenario, System.Numerics.Vector3 SpawnLoc, BmSDK.Rotator SpawnRot, float RoadWidth, BmSDK.TArray<BmSDK.Engine.Volume> BehaviourVolumes, BmSDK.BmGame.RPatrolPoint PatrolRoute, bool ObeyExclusionZones, byte SpawnType, BmSDK.BmGame.RVehicleNPC AlreadySpawned0thVehicle = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SpawnVehicleScenarioDeferred", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scenario, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRot, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoadWidth, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourVolumes, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PatrolRoute, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObeyExclusionZones, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnType, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlreadySpawned0thVehicle, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindAAITakedownTypeFromGameAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.AAITakedownType FindAAITakedownTypeFromGameAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindAAITakedownTypeFromGameAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.AAITakedownType>(paramsPtr + 1);
    }

    /// <summary>
    /// Function: FlushStats
    /// </summary>
    public unsafe void FlushStats()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FlushStats", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WriteOnlineStats
    /// </summary>
    public unsafe void WriteOnlineStats()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.WriteOnlineStats", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Is3DTVPresent
    /// </summary>
    public unsafe bool Is3DTVPresent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Is3DTVPresent", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetOceanHeightAtLocation
    /// </summary>
    public unsafe static float GetOceanHeightAtLocation(System.Numerics.Vector3 vTestLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetOceanHeightAtLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vTestLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetFearGasHeightAtLocation
    /// </summary>
    public unsafe static float GetFearGasHeightAtLocation(System.Numerics.Vector3 vTestLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetFearGasHeightAtLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vTestLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: IsLocationInFearGas
    /// </summary>
    public unsafe static bool IsLocationInFearGas(System.Numerics.Vector3 vTestLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsLocationInFearGas", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vTestLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: IsFearGasActive
    /// </summary>
    public unsafe static bool IsFearGasActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsFearGasActive", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLevelTransitionOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 GetLevelTransitionOffset(BmSDK.FName CurrentLevel, BmSDK.FString TargetLevel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLevelTransitionOffset", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentLevel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLevel, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: GetMapElementItemListIndex
    /// </summary>
    public unsafe int GetMapElementItemListIndex(BmSDK.FString marker_name)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetMapElementItemListIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(marker_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: UpdateMapElementList
    /// </summary>
    public unsafe void UpdateMapElementList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateMapElementList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMostProminentSwappableBillboard
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerSwappableBase GetMostProminentSwappableBillboard(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetMostProminentSwappableBillboard", true);
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
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerSwappableBase>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UndoLightningSwap
    /// </summary>
    public unsafe void UndoLightningSwap()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UndoLightningSwap", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateJokerBillboards
    /// </summary>
    public unsafe void UpdateJokerBillboards(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateJokerBillboards", true);
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
    /// Function: UpdateOWLightFade
    /// </summary>
    public unsafe void UpdateOWLightFade(float DeltaTime, BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateOWLightFade", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
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
    /// Function: DrawJokerBillboardDebug
    /// </summary>
    public unsafe void DrawJokerBillboardDebug(int currChapter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DrawJokerBillboardDebug", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currChapter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyJokerBillboardSwapped
    /// </summary>
    public unsafe void NotifyJokerBillboardSwapped(BmSDK.BmGame.RJokerSwappableBase billboard, bool bSwappedToJokerVersion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.NotifyJokerBillboardSwapped", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(billboard, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSwappedToJokerVersion, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnRegisterJokerBillboard
    /// </summary>
    public unsafe void UnRegisterJokerBillboard(BmSDK.BmGame.RJokerSwappableBase billboard)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UnRegisterJokerBillboard", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(billboard, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterJokerBillboard
    /// </summary>
    public unsafe void RegisterJokerBillboard(BmSDK.BmGame.RJokerSwappableBase billboard)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RegisterJokerBillboard", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(billboard, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddInformantInterrogated
    /// </summary>
    public unsafe void AddInformantInterrogated(System.Numerics.Vector3 InformantLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AddInformantInterrogated", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InformantLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanSpawnInformant
    /// </summary>
    public unsafe bool CanSpawnInformant(BmSDK.BmGame.RGameInfo.EDistrict CityDistrict)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CanSpawnInformant", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CityDistrict, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: NumInformantsForZone
    /// </summary>
    public unsafe int NumInformantsForZone(BmSDK.BmGame.RGameInfo.EDistrict CityD)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.NumInformantsForZone", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CityD, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UpdateSharedRiddlerMapIcons
    /// </summary>
    public unsafe void UpdateSharedRiddlerMapIcons()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateSharedRiddlerMapIcons", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RiddlerIcons_GetIndexListOfClosest
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem> RiddlerIcons_GetIndexListOfClosest(BmSDK.FString MapName, int atX, int atY, int atZ, int MaxWanted)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerIcons_GetIndexListOfClosest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWanted, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem>>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetParentSubName
    /// </summary>
    public unsafe BmSDK.FString GetParentSubName(BmSDK.FString MapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetParentSubName", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetSubIndexFromMapName
    /// </summary>
    public unsafe int GetSubIndexFromMapName(BmSDK.FString MapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetSubIndexFromMapName", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetSubMapLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 GetSubMapLoc(BmSDK.FString MapName, bool bInternalEntranceLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetSubMapLoc", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInternalEntranceLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: IsMapOverworld
    /// </summary>
    public unsafe bool IsMapOverworld(BmSDK.FString MapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsMapOverworld", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: RiddlerIcons_GetIndexListForNearestToLoc
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem> RiddlerIcons_GetIndexListForNearestToLoc(BmSDK.FString MapName, int atX, int atY, int atZ, int MaxWanted, bool bHiddenOnly)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerIcons_GetIndexListForNearestToLoc", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWanted, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHiddenOnly, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem>>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: RiddlerIcons_GetSecretsLeftIncTypeForMap
    /// </summary>
    public unsafe int RiddlerIcons_GetSecretsLeftIncTypeForMap(BmSDK.FString MapName, out int Trophys, out int Cameos, out int Breakables, out int Bombs)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerIcons_GetSecretsLeftIncTypeForMap", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Trophys = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        Cameos = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
        Breakables = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        Bombs = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetTrueMapName
    /// </summary>
    public unsafe BmSDK.FString GetTrueMapName(BmSDK.FString MapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetTrueMapName", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ContentBeaconManifestLoaded
    /// </summary>
    public unsafe void ContentBeaconManifestLoaded(bool bWasSuccessful, BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ContentBeaconManifestLoaded", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ContentBeaconInitiateHydraQuery
    /// </summary>
    public unsafe void ContentBeaconInitiateHydraQuery()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ContentBeaconInitiateHydraQuery", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ContentBeaconShouldHideHud
    /// </summary>
    public unsafe bool ContentBeaconShouldHideHud()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ContentBeaconShouldHideHud", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ContentBeaconPanelEnable
    /// </summary>
    public unsafe void ContentBeaconPanelEnable(BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode eDisplayMode, int nBeacon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ContentBeaconPanelEnable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eDisplayMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nBeacon, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ContentBeaconsEnableEmitter
    /// </summary>
    public unsafe BmSDK.Engine.REmitter ContentBeaconsEnableEmitter(BmSDK.Engine.REmitter E, BmSDK.Engine.ParticleSystem Template, System.Numerics.Vector3 Position = default, float YawRotation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ContentBeaconsEnableEmitter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(E, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawRotation, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: ContentBeaconsInteract
    /// </summary>
    public unsafe bool ContentBeaconsInteract(int nBeacon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ContentBeaconsInteract", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nBeacon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ContentBeaconsUpdateNearby
    /// </summary>
    public unsafe void ContentBeaconsUpdateNearby(System.Numerics.Vector3 vPosition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ContentBeaconsUpdateNearby", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vPosition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PositionBeaconUpdateSpring
    /// </summary>
    public unsafe bool PositionBeaconUpdateSpring(out System.Numerics.Vector3 vSpring, out System.Numerics.Vector3 vOutput, float fDistance, float fMaxRange, float fMinRange, float fFrameTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PositionBeaconUpdateSpring", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDistance, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fMaxRange, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fMinRange, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fFrameTime, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        vSpring = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        vOutput = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Function: PositionBeaconUIAllowed
    /// </summary>
    public unsafe bool PositionBeaconUIAllowed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PositionBeaconUIAllowed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PositionBeaconDisabledByGameState
    /// </summary>
    public unsafe bool PositionBeaconDisabledByGameState(out BmSDK.FString sError, int nId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PositionBeaconDisabledByGameState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        sError = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: PositionBeaconShouldBeHidden
    /// </summary>
    public unsafe bool PositionBeaconShouldBeHidden()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PositionBeaconShouldBeHidden", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PositionBeaconGetBest
    /// </summary>
    public unsafe bool PositionBeaconGetBest(out BmSDK.FString sType, out int nId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PositionBeaconGetBest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        sType = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        nId = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: PositionBeaconUpdateCenterMostAndClosest
    /// </summary>
    public unsafe void PositionBeaconUpdateCenterMostAndClosest(System.Numerics.Vector3 vInteractPosition, System.Numerics.Vector3 vLookPosition, System.Numerics.Vector3 vLookDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PositionBeaconUpdateCenterMostAndClosest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vInteractPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vLookPosition, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vLookDirection, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PositionBeaconRegister
    /// </summary>
    public unsafe void PositionBeaconRegister(System.Numerics.Vector3 vPosition, BmSDK.FString sType, int nId, float fInteractRadius = default, float fRadius = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PositionBeaconRegister", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fInteractRadius, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRadius, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RiddlerPuzzleAutoBackscreen
    /// </summary>
    public unsafe void RiddlerPuzzleAutoBackscreen()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerPuzzleAutoBackscreen", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RiddlerPuzzleGetPieceStateCount
    /// </summary>
    public unsafe int RiddlerPuzzleGetPieceStateCount(BmSDK.BmGame.RGameInfo.ERiddlerState eMinState, BmSDK.BmGame.RGameInfo.ERiddlerState eMaxState, BmSDK.BmGame.RGameInfo.ERiddlerCategory eCategory = default, BmSDK.BmGame.RGameInfo.ERiddlerPiece ePiece = default, byte nPuzzleId = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerPuzzleGetPieceStateCount", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eMinState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eMaxState, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCategory, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ePiece, paramsPtr + 3);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzleId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: RiddlerPuzzleGetIndexById
    /// </summary>
    public unsafe int RiddlerPuzzleGetIndexById(int nId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerPuzzleGetIndexById", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: RiddlerPuzzleSetPieceStateByIndex
    /// </summary>
    public unsafe void RiddlerPuzzleSetPieceStateByIndex(byte nPuzzleIndex, byte nPieceIndex = default, BmSDK.BmGame.RGameInfo.ERiddlerState eState = default, bool bImprovedStateOnly = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerPuzzleSetPieceStateByIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzleIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPieceIndex, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eState, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImprovedStateOnly, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RiddlerPuzzleSetPieceState
    /// </summary>
    public unsafe bool RiddlerPuzzleSetPieceState(BmSDK.BmGame.RGameInfo.ERiddlerCategory eCategory, BmSDK.BmGame.RGameInfo.ERiddlerPiece ePiece, byte nPieceId, BmSDK.BmGame.RGameInfo.ERiddlerState eState = default, bool bImprovedStateOnly = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerPuzzleSetPieceState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCategory, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ePiece, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPieceId, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eState, paramsPtr + 3);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImprovedStateOnly, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: RiddlerPuzzleSolve
    /// </summary>
    public unsafe int RiddlerPuzzleSolve(BmSDK.BmGame.RGameInfo.ERiddlerCategory eCategory, BmSDK.BmGame.RGameInfo.ERiddlerPiece ePiece, byte nPieceId, BmSDK.BmGame.RGameInfo.ERiddlerCollection eCollection = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerPuzzleSolve", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCategory, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ePiece, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPieceId, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCollection, paramsPtr + 3);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: RiddlerPuzzleUnlockCategory
    /// </summary>
    public unsafe void RiddlerPuzzleUnlockCategory(BmSDK.BmGame.RGameInfo.ERiddlerCategory eCategory)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerPuzzleUnlockCategory", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCategory, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RiddlerPuzzleCollect
    /// </summary>
    public unsafe int RiddlerPuzzleCollect(BmSDK.BmGame.RGameInfo.ERiddlerCategory eCategory, BmSDK.BmGame.RGameInfo.ERiddlerCollection eCollection, int nAmount = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerPuzzleCollect", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCategory, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCollection, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: RiddlerZoneToCategory
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.ERiddlerCategory RiddlerZoneToCategory(BmSDK.BmGame.RGameInfo.ERiddlerLocationName eLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerZoneToCategory", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ERiddlerCategory>(paramsPtr + 1);
    }

    /// <summary>
    /// Function: StoreContentPopulateWithDebugInformation
    /// </summary>
    public unsafe void StoreContentPopulateWithDebugInformation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.StoreContentPopulateWithDebugInformation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StoreContentProductIdExists
    /// </summary>
    public unsafe bool StoreContentProductIdExists(BmSDK.FString sId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.StoreContentProductIdExists", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: StoreContentCancelCallback
    /// </summary>
    public unsafe void StoreContentCancelCallback()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.StoreContentCancelCallback", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StoreContentQueryComplete
    /// </summary>
    public unsafe void StoreContentQueryComplete(bool bWasSuccessful, bool bTimeout = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.StoreContentQueryComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTimeout, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StoreContentQueryCompleteStandard
    /// </summary>
    public unsafe void StoreContentQueryCompleteStandard(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.StoreContentQueryCompleteStandard", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StoreContentQueryTimeout
    /// </summary>
    public unsafe void StoreContentQueryTimeout()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.StoreContentQueryTimeout", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StoreContentClearDelegates
    /// </summary>
    public unsafe void StoreContentClearDelegates()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.StoreContentClearDelegates", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StoreContentStatusChanged
    /// </summary>
    public unsafe void StoreContentStatusChanged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.StoreContentStatusChanged", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StoreContentInitiateQuery
    /// </summary>
    public unsafe bool StoreContentInitiateQuery(int nControllerId, System.IntPtr fnCallback = default, bool bForceUpdate = default, bool bDebugData = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.StoreContentInitiateQuery", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fnCallback, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceUpdate, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugData, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: OnStoreContentQueryComplete
    /// </summary>
    public unsafe void OnStoreContentQueryComplete(bool bSuccess, bool bTimeout)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.OnStoreContentQueryComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTimeout, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpgradeValidateBoosters
    /// </summary>
    public unsafe bool UpgradeValidateBoosters(out BmSDK.FString sMessage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpgradeValidateBoosters", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        sMessage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: UpgradeApplyBooster
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.UpgradeBoostAction UpgradeApplyBooster(BmSDK.FString sUpgrade, out int nPoints)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpgradeApplyBooster", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sUpgrade, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        nPoints = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.UpgradeBoostAction>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: UpgradesBuildHierarchy
    /// </summary>
    public unsafe void UpgradesBuildHierarchy()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpgradesBuildHierarchy", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpgradesUnlockAll
    /// </summary>
    public unsafe int UpgradesUnlockAll(out int nPoints)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpgradesUnlockAll", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        nPoints = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UpgradesGetPageCounts
    /// </summary>
    public unsafe void UpgradesGetPageCounts(out int nTotal, out int nPurchasable, out int nOwned, out int nPrerequisites, out int nNew, BmSDK.FString sPage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpgradesGetPageCounts", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPage, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        nTotal = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        nPurchasable = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        nOwned = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        nPrerequisites = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
        nNew = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: GetNumPurchaseableUpgrades
    /// </summary>
    public unsafe int GetNumPurchaseableUpgrades()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetNumPurchaseableUpgrades", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpgradesGetTotalNeededPoints
    /// </summary>
    public unsafe int UpgradesGetTotalNeededPoints(BmSDK.FString sItem = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpgradesGetTotalNeededPoints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sItem, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ShowcaseGetItemWithSkin
    /// </summary>
    public unsafe int ShowcaseGetItemWithSkin(BmSDK.FString sSkin, BmSDK.FString sPage = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShowcaseGetItemWithSkin", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSkin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPage, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: ShowcaseGetTotalCollected
    /// </summary>
    public unsafe int ShowcaseGetTotalCollected(out int nTotalPossible, out int nNewCollected)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShowcaseGetTotalCollected", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        nTotalPossible = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        nNewCollected = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ShowcaseValidateSorting
    /// </summary>
    public unsafe void ShowcaseValidateSorting()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShowcaseValidateSorting", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: _ShowcaseItemsSort
    /// </summary>
    public unsafe int _ShowcaseItemsSort(BmSDK.BmGame.RGameInfo.FShowcaseItem A, BmSDK.BmGame.RGameInfo.FShowcaseItem B)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo._ShowcaseItemsSort", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 136);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 272);
    }

    /// <summary>
    /// Function: ChallengeCharacterGetActiveBatmobile
    /// </summary>
    public unsafe int ChallengeCharacterGetActiveBatmobile(bool bStandardIsDefault = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ChallengeCharacterGetActiveBatmobile", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStandardIsDefault, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AddDLCChallengeCharacterIds
    /// </summary>
    public unsafe void AddDLCChallengeCharacterIds()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AddDLCChallengeCharacterIds", true);
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
    /// Function: ChallengeCharacterNameById
    /// </summary>
    public unsafe BmSDK.FString ChallengeCharacterNameById(int nId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ChallengeCharacterNameById", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ChallengeCharacterOverrideByName
    /// </summary>
    public unsafe BmSDK.FString ChallengeCharacterOverrideByName(BmSDK.FString sName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ChallengeCharacterOverrideByName", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ChallengeCharacterIdByName
    /// </summary>
    public unsafe int ChallengeCharacterIdByName(BmSDK.FString sName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ChallengeCharacterIdByName", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ConceptGetTotalCollected
    /// </summary>
    public unsafe int ConceptGetTotalCollected(out int nTotalPossible, out int nNewCollected)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ConceptGetTotalCollected", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        nTotalPossible = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        nNewCollected = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CustomContentIsFiltered
    /// </summary>
    public unsafe bool CustomContentIsFiltered(BmSDK.FString sFilter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CustomContentIsFiltered", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sFilter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CustomContentHandleAction
    /// </summary>
    public unsafe bool CustomContentHandleAction(BmSDK.FString sAction, out BmSDK.FString sName, out BmSDK.FString sData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CustomContentHandleAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        sName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
        sData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: IsCoreStory
    /// </summary>
    public unsafe bool IsCoreStory()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsCoreStory", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsGasActive
    /// </summary>
    public unsafe bool IsGasActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsGasActive", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsBatmobileAvailableForChallenge
    /// </summary>
    public unsafe bool IsBatmobileAvailableForChallenge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsBatmobileAvailableForChallenge", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SortByIndexDist
    /// </summary>
    public unsafe int SortByIndexDist(BmSDK.BmGame.RGameInfo.FIndexDistItem A, BmSDK.BmGame.RGameInfo.FIndexDistItem B)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SortByIndexDist", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ToggleDebugCamera
    /// </summary>
    public unsafe void ToggleDebugCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ToggleDebugCamera", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowPointOfInterestDebug
    /// </summary>
    public unsafe void ShowPointOfInterestDebug()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShowPointOfInterestDebug", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPointOfInterestIndex
    /// </summary>
    public unsafe int GetPointOfInterestIndex(BmSDK.Engine.Actor TheActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPointOfInterestIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: DeRegisterHelicopterPointOfInterest
    /// </summary>
    public unsafe void DeRegisterHelicopterPointOfInterest(BmSDK.Engine.Actor TheActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DeRegisterHelicopterPointOfInterest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterHelicopterPointOfInterest
    /// </summary>
    public unsafe void RegisterHelicopterPointOfInterest(BmSDK.Engine.Actor TheActor, BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes PoiType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RegisterHelicopterPointOfInterest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoiType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnregisterHelicopter
    /// </summary>
    public unsafe void UnregisterHelicopter(BmSDK.BmGame.RHelicopterBase OldHeli)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UnregisterHelicopter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldHeli, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterHelicopter
    /// </summary>
    public unsafe void RegisterHelicopter(BmSDK.BmGame.RHelicopterBase NewHeli)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RegisterHelicopter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHeli, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsSmokeScreenBlockingTakedown
    /// </summary>
    public unsafe bool IsSmokeScreenBlockingTakedown(System.Numerics.Vector3 WorldPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsSmokeScreenBlockingTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetSmokeScreenCoverValue
    /// </summary>
    public unsafe float GetSmokeScreenCoverValue(System.Numerics.Vector3 WorldPos, out byte bFireExtinguisher, out BmSDK.BmGame.RSmokeScreen MainSmokeScreen)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetSmokeScreenCoverValue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bFireExtinguisher = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 12);
        MainSmokeScreen = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSmokeScreen>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: UpdateObjectiveMarkerVisibility
    /// </summary>
    public unsafe void UpdateObjectiveMarkerVisibility(bool ForcePlayerWaypoint = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateObjectiveMarkerVisibility", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForcePlayerWaypoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueUpdateObjectiveMarker
    /// </summary>
    public unsafe void QueueUpdateObjectiveMarker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.QueueUpdateObjectiveMarker", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetObjectiveSystemSuppressed
    /// </summary>
    public unsafe void SetObjectiveSystemSuppressed(bool is_suppressed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetObjectiveSystemSuppressed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_suppressed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateObjectiveMarker
    /// </summary>
    public unsafe void ActivateObjectiveMarker(BmSDK.FName roomName, bool show)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ActivateObjectiveMarker", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(roomName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldSpawnAtStartSpot
    /// </summary>
    public unsafe bool ShouldSpawnAtStartSpot(BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShouldSpawnAtStartSpot", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: EndGame
    /// </summary>
    public unsafe void EndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.EndGame", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RoundEnded
    /// </summary>
    public unsafe void RoundEnded()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RoundEnded", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RatePlayerStart
    /// </summary>
    public unsafe float RatePlayerStart(BmSDK.Engine.PlayerStart P, byte Team, BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RatePlayerStart", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GameOver
    /// </summary>
    public unsafe void GameOver(float TimeTillFade = default, bool PlayerDied = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GameOver", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeTillFade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerDied, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerDied
    /// </summary>
    public unsafe void PlayerDied(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PlayerDied", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostLogin
    /// </summary>
    public unsafe void PostLogin(BmSDK.Engine.PlayerController NewPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PostLogin", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleSeamlessTravelPlayer
    /// </summary>
    public unsafe void HandleSeamlessTravelPlayer(out BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HandleSeamlessTravelPlayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: HandleLobby
    /// </summary>
    public unsafe void HandleLobby(BmSDK.BmGame.RPlayerController LobbyPC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HandleLobby", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowLobby
    /// </summary>
    public unsafe bool ShowLobby(BmSDK.BmGame.RPlayerController LobbyTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShowLobby", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GoFrontend
    /// </summary>
    public unsafe void GoFrontend(BmSDK.FString ExtraParams = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GoFrontend", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraParams, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_ExitToFrontend
    /// </summary>
    public unsafe void Game_ExitToFrontend()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_ExitToFrontend", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_PauseExitToFrontend
    /// </summary>
    public unsafe void Game_PauseExitToFrontend()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_PauseExitToFrontend", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_Retry
    /// </summary>
    public unsafe void Game_Retry()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_Retry", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPCBinds
    /// </summary>
    public unsafe void SetPCBinds()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetPCBinds", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_Restart
    /// </summary>
    public unsafe void Game_Restart()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_Restart", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGameRestartOneshot
    /// </summary>
    public unsafe void SetGameRestartOneshot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetGameRestartOneshot", true);
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
    /// Function: Game_EndChallenge
    /// </summary>
    public unsafe void Game_EndChallenge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_EndChallenge", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_ExitGame
    /// </summary>
    public unsafe void Game_ExitGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_ExitGame", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_Continue
    /// </summary>
    public unsafe void Game_Continue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_Continue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_StartGameAt
    /// </summary>
    public unsafe void Game_StartGameAt(BmSDK.FString AtName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_StartGameAt", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AtName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDefaultPlayerClass
    /// </summary>
    public unsafe BmSDK.Class GetDefaultPlayerClass(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetDefaultPlayerClass", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetPlayerCharacterIndex
    /// </summary>
    public unsafe int GetPlayerCharacterIndex(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlayerCharacterIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SpawnBatmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase SpawnBatmobile(System.Numerics.Vector3 Loc, BmSDK.Rotator Rot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SpawnBatmobile", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: GetBatmobileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase GetBatmobileArchetype()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetBatmobileArchetype", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FixupGadgetsPC
    /// </summary>
    public unsafe void FixupGadgetsPC(BmSDK.BmGame.RPawnPlayer Pawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FixupGadgetsPC", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnDefaultPawnFor
    /// </summary>
    public unsafe BmSDK.Engine.Pawn SpawnDefaultPawnFor(BmSDK.Engine.Controller NewPlayer, BmSDK.Engine.NavigationPoint StartSpot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SpawnDefaultPawnFor", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSpot, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ProcessServerLogin
    /// </summary>
    public unsafe bool ProcessServerLogin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ProcessServerLogin", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetURLParam
    /// </summary>
    public unsafe BmSDK.FString GetURLParam(BmSDK.FString Named)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetURLParam", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Named, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: HasURLParam
    /// </summary>
    public unsafe bool HasURLParam(BmSDK.FString Named)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HasURLParam", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Named, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetGameTimePlayedString
    /// </summary>
    public unsafe BmSDK.FString GetGameTimePlayedString()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetGameTimePlayedString", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGameTimePlayed
    /// </summary>
    public unsafe float GetGameTimePlayed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetGameTimePlayed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: VoiceHasEmote
    /// </summary>
    public unsafe static bool VoiceHasEmote(BmSDK.Engine.AkDialogueVoice Voice, BmSDK.Engine.AkEmoteType emType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.VoiceHasEmote", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Voice, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(emType, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: IsFrontend
    /// </summary>
    public unsafe bool IsFrontend()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsFrontend", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsChallengeMode
    /// </summary>
    public unsafe bool IsChallengeMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsChallengeMode", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsStoryMode
    /// </summary>
    public unsafe bool IsStoryMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsStoryMode", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGameMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameModes GetGameMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetGameMode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameModes>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindPredatorVolumeForPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPredatorVolume FindPredatorVolumeForPoint(System.Numerics.Vector3 TestPoint, BmSDK.Engine.Level L = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindPredatorVolumeForPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(L, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPredatorVolume>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: FindPredatorVolumeFor
    /// </summary>
    public unsafe BmSDK.BmGame.RPredatorVolume FindPredatorVolumeFor(BmSDK.Engine.Actor TestActor, bool bMustBeSameLevel = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindPredatorVolumeFor", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMustBeSameLevel, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPredatorVolume>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ResetRoom
    /// </summary>
    public unsafe void ResetRoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ResetRoom", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnhookRoomState
    /// </summary>
    public unsafe void UnhookRoomState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UnhookRoomState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNewRoomAIState
    /// </summary>
    public unsafe void SetNewRoomAIState(BmSDK.BmGame.RBMRoomAIState NewState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetNewRoomAIState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPredatorChaseTime
    /// </summary>
    public unsafe float GetPredatorChaseTime()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPredatorChaseTime", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateGameWindConfig
    /// </summary>
    public unsafe void UpdateGameWindConfig(BmSDK.BmGame.RGameInfo.FRBasicWindConfig NewWind)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateGameWindConfig", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWind, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpPawnLevelVol
    /// </summary>
    public unsafe void DumpPawnLevelVol()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpPawnLevelVol", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpRoomState
    /// </summary>
    public unsafe void DumpRoomState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpRoomState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpBarkCoord
    /// </summary>
    public unsafe void DumpBarkCoord()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpBarkCoord", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpAllNav
    /// </summary>
    public unsafe void DumpAllNav()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpAllNav", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MakeNervous
    /// </summary>
    public unsafe void MakeNervous()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.MakeNervous", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MakeTerrified
    /// </summary>
    public unsafe void MakeTerrified()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.MakeTerrified", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BarkDewedge
    /// </summary>
    public unsafe void BarkDewedge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.BarkDewedge", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BarkWTF
    /// </summary>
    public unsafe void BarkWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.BarkWTF", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InformVillainsOfFlipGrateEntry
    /// </summary>
    public unsafe bool InformVillainsOfFlipGrateEntry(BmSDK.Engine.Pawn VentPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InformVillainsOfFlipGrateEntry", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VentPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: InformVillainsOfVentEntry
    /// </summary>
    public unsafe bool InformVillainsOfVentEntry(BmSDK.Engine.Pawn VentPlayer, BmSDK.BmGame.RTunnelGrateBase EntryGrate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InformVillainsOfVentEntry", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VentPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EntryGrate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: DisableAnyChases
    /// </summary>
    public unsafe void DisableAnyChases(bool bDisableAnyActiveAPCChases = default, bool bDisableAnyActivePenguinVanChases = default, bool bDisableAnyActiveRiddlerTrophyChases = default, bool bDisableAnyActiveFireflyChases = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DisableAnyChases", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisableAnyActiveAPCChases, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisableAnyActivePenguinVanChases, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisableAnyActiveRiddlerTrophyChases, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisableAnyActiveFireflyChases, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProcessPlayerEscape
    /// </summary>
    public unsafe void ProcessPlayerEscape(BmSDK.BmGame.RPawnPlayer EscapePlayer, bool bSniperBossSpecial = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ProcessPlayerEscape", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscapePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSniperBossSpecial, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InformVillainsPostGrapple
    /// </summary>
    public unsafe bool InformVillainsPostGrapple(BmSDK.Engine.Pawn GrapplePlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InformVillainsPostGrapple", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: NotifyAIOfGrapple
    /// </summary>
    public unsafe void NotifyAIOfGrapple(BmSDK.Engine.Pawn GrapplePlayer, System.Numerics.Vector3 TargetHidePointLocation, bool bPlayerEscaped, bool CanAISeePlayer, bool bSniperBossSpecial = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.NotifyAIOfGrapple", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetHidePointLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayerEscaped, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanAISeePlayer, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSniperBossSpecial, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanAISeePlayerForGrapple
    /// </summary>
    public unsafe void CanAISeePlayerForGrapple(BmSDK.Engine.Pawn GrapplePlayer, System.Numerics.Vector3 TargetHidePointLocation, bool bForcingBatmanHidden, out int bVillainHasSeen, out int bAllowPlayerToHide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CanAISeePlayerForGrapple", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetHidePointLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForcingBatmanHidden, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bVillainHasSeen = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        bAllowPlayerToHide = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
        return;
    }

    /// <summary>
    /// Function: IsShootingSourceGarg
    /// </summary>
    public unsafe bool IsShootingSourceGarg(BmSDK.Engine.Pawn GrapplePlayer, BmSDK.BmGame.RBMAIController AIC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsShootingSourceGarg", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AIC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: PlayerIsOnVantageBeingShotByThug
    /// </summary>
    public unsafe bool PlayerIsOnVantageBeingShotByThug(BmSDK.BmGame.RPawnPlayer GrapplePlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PlayerIsOnVantageBeingShotByThug", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ThugCanSeeOtherThugToInterruptAttack
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain ThugCanSeeOtherThugToInterruptAttack(BmSDK.BmGame.RPawnVillain ThugBeingAttacked)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ThugCanSeeOtherThugToInterruptAttack", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugBeingAttacked, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: FireFailsafeSeenEvents
    /// </summary>
    public unsafe void FireFailsafeSeenEvents()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FireFailsafeSeenEvents", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CopyViewStateParamsForRenderThread
    /// </summary>
    public unsafe void CopyViewStateParamsForRenderThread()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CopyViewStateParamsForRenderThread", true);
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
    /// Function: GetWindAtPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GetWindAtPoint(System.Numerics.Vector3 ObjectPosition, System.Numerics.Vector3 ObjectVelocity)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetWindAtPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectVelocity, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: UpdateGlobalWind
    /// </summary>
    public unsafe void UpdateGlobalWind(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateGlobalWind", true);
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
    /// Function: TickPostUpdate
    /// </summary>
    public unsafe void TickPostUpdate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TickPostUpdate", true);
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
    /// Function: TickDuringAsync
    /// </summary>
    public unsafe void TickDuringAsync(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TickDuringAsync", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Tick", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveExclusionVolume
    /// </summary>
    public unsafe void RemoveExclusionVolume(BmSDK.BmGame.RVehicleExclusionVolume Volume)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RemoveExclusionVolume", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Volume, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddExclusionVolume
    /// </summary>
    public unsafe void AddExclusionVolume(BmSDK.BmGame.RVehicleExclusionVolume Volume)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AddExclusionVolume", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Volume, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Killed
    /// </summary>
    public unsafe void Killed(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Killed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LoadPB
    /// </summary>
    public unsafe void LoadPB(BmSDK.FName PBName = default, int DamageLevel = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.LoadPB", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PBName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageLevel, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LoadPC
    /// </summary>
    public unsafe void LoadPC(BmSDK.FName PCName = default, int DamageLevel = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.LoadPC", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PCName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageLevel, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GoStartMatch
    /// </summary>
    public unsafe void GoStartMatch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GoStartMatch", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDualPlayPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer GetDualPlayPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetDualPlayPawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer GetPlayerPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlayerPawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetPlayerStartPoints
    /// </summary>
    public unsafe void ResetPlayerStartPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ResetPlayerStartPoints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckToStartMatch
    /// </summary>
    public unsafe void CheckToStartMatch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CheckToStartMatch", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TimedStartGame
    /// </summary>
    public unsafe void TimedStartGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TimedStartGame", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RestartPlayer
    /// </summary>
    public unsafe void RestartPlayer(BmSDK.Engine.Controller NewPlayer, bool bForPlayerSwitch = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RestartPlayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForPlayerSwitch, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe void OnLevelChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.OnLevelChange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreCommitMapChange
    /// </summary>
    public unsafe void PreCommitMapChange(BmSDK.FString PreviousMapName, BmSDK.FString NextMapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PreCommitMapChange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousMapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateStatsLogging
    /// </summary>
    public unsafe void CreateStatsLogging()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CreateStatsLogging", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostCommitMapChange
    /// </summary>
    public unsafe void PostCommitMapChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PostCommitMapChange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe void PreBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PreBeginPlay", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateLevelVolumeList
    /// </summary>
    public unsafe void UpdateLevelVolumeList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateLevelVolumeList", true);
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
    /// Function: SendHydraBeginGameplayEvent
    /// </summary>
    public unsafe void SendHydraBeginGameplayEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SendHydraBeginGameplayEvent", true);
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
    /// Function: PredicateUturnBark
    /// </summary>
    public unsafe bool PredicateUturnBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PredicateUturnBark", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetupModeStuff
    /// </summary>
    public unsafe void SetupModeStuff(BmSDK.BmGame.RGameInfo.EGameModes eDesiredGameMode = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetupModeStuff", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eDesiredGameMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateDisableSlowStuff
    /// </summary>
    public unsafe void UpdateDisableSlowStuff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateDisableSlowStuff", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe void Dump()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Dump", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsDemoBuild
    /// </summary>
    public unsafe bool IsDemoBuild()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsDemoBuild", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AllowCheats
    /// </summary>
    public unsafe bool AllowCheats(BmSDK.Engine.PlayerController P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AllowCheats", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe int GetDifficulty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetDifficulty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsGadgetAction
    /// </summary>
    public unsafe bool IsGadgetAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsGadgetAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsStunAction
    /// </summary>
    public unsafe bool IsStunAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsStunAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsSpecialAction
    /// </summary>
    public unsafe bool IsSpecialAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsSpecialAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsRepeatedAction
    /// </summary>
    public unsafe bool IsRepeatedAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsRepeatedAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsTakedownAction
    /// </summary>
    public unsafe bool IsTakedownAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsTakedownAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsCombatKOAction
    /// </summary>
    public unsafe bool IsCombatKOAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsCombatKOAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: WaitToBankXP
    /// </summary>
    public unsafe bool WaitToBankXP()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.WaitToBankXP", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: WaitToBankVehicleXP
    /// </summary>
    public unsafe bool WaitToBankVehicleXP()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.WaitToBankVehicleXP", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime
    /// </summary>
    public unsafe static BmSDK.GameObject HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLastInstallChunk
    /// </summary>
    public unsafe static BmSDK.BmGame.RGameInfo.EInstallChunk GetLastInstallChunk()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLastInstallChunk", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EInstallChunk>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsCurrentPredZoneAlerted
    /// </summary>
    public unsafe bool IsCurrentPredZoneAlerted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsCurrentPredZoneAlerted", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindProjectileArc
    /// </summary>
    public unsafe bool FindProjectileArc(BmSDK.Engine.Actor TraceActor, out System.Numerics.Vector3 ThrowVelocity, out float FlightTime, System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindProjectileArc", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThrowVelocity = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        FlightTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: SecuROMProtectionCheck4
    /// </summary>
    public unsafe int SecuROMProtectionCheck4(int A, int B)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck4", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
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
    /// Function: SecuROMProtectionCheck3
    /// </summary>
    public unsafe int SecuROMProtectionCheck3()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck3", true);
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
    /// Function: SecuROMProtectionCheck2
    /// </summary>
    public unsafe bool SecuROMProtectionCheck2()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck2", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SecuROMProtectionCheck1
    /// </summary>
    public unsafe bool SecuROMProtectionCheck1()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck1", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLanguageForScriptCode
    /// </summary>
    public unsafe BmSDK.FString GetLanguageForScriptCode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLanguageForScriptCode", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBatmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase GetBatmobile()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetBatmobile", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPlyrPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer GetPlyrPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlyrPawn", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerControllerCombat GetPC()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPC", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerCombat>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumLocalPlayers
    /// </summary>
    public unsafe int GetNumLocalPlayers()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetNumLocalPlayers", true);
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
    /// Function: GetLevelVolumeFor
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelVolume GetLevelVolumeFor(BmSDK.GameObject Obj)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLevelVolumeFor", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetXrayFadeValueForItem
    /// </summary>
    public unsafe float GetXrayFadeValueForItem(BmSDK.Engine.Actor TestActor, BmSDK.Engine.MeshComponent MainMesh = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetXrayFadeValueForItem", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MainMesh, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetEpisodeIndexByName
    /// </summary>
    public unsafe int GetEpisodeIndexByName(BmSDK.FString sName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetEpisodeIndexByName", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetEpisodeIndexBySortId
    /// </summary>
    public unsafe int GetEpisodeIndexBySortId(int Uid)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetEpisodeIndexBySortId", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsEpisodePresent
    /// </summary>
    public unsafe bool IsEpisodePresent(int Uid)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsEpisodePresent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsAnEpisodeAvailable
    /// </summary>
    public unsafe bool IsAnEpisodeAvailable(out int Count)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsAnEpisodeAvailable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Count = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetEpisodeCount
    /// </summary>
    public unsafe int GetEpisodeCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetEpisodeCount", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UnregisterBatmobileForensicsSideStory
    /// </summary>
    public unsafe void UnregisterBatmobileForensicsSideStory(BmSDK.BmGame.RSeqAct_BatmobileForensicsSideStory the_seqact)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UnregisterBatmobileForensicsSideStory", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_seqact, paramsPtr + 0);
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
    /// Function: RegisterBatmobileForensicsSideStory
    /// </summary>
    public unsafe void RegisterBatmobileForensicsSideStory(BmSDK.BmGame.RSeqAct_BatmobileForensicsSideStory the_seqact)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RegisterBatmobileForensicsSideStory", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_seqact, paramsPtr + 0);
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
    /// Function: GetTimeSinceAnySpeech
    /// </summary>
    public unsafe float GetTimeSinceAnySpeech()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetTimeSinceAnySpeech", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsLocationInPlayerCameraFrustum
    /// </summary>
    public unsafe bool IsLocationInPlayerCameraFrustum(System.Numerics.Vector3 InLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsLocationInPlayerCameraFrustum", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLoc, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetIsSaveInProgress
    /// </summary>
    public unsafe bool GetIsSaveInProgress()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetIsSaveInProgress", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSaveGameSize
    /// </summary>
    public unsafe int GetSaveGameSize()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetSaveGameSize", true);
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
    /// Function: IsDLCInstalled
    /// </summary>
    public unsafe bool IsDLCInstalled(BmSDK.FString DLCBundleName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsDLCInstalled", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DLCBundleName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetLevelLoadedAndVisible
    /// </summary>
    public unsafe bool GetLevelLoadedAndVisible(BmSDK.FName LevelName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLevelLoadedAndVisible", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SetLevelVisible
    /// </summary>
    public unsafe void SetLevelVisible(BmSDK.FName LevelName, bool Visible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetLevelVisible", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Visible, paramsPtr + 8);
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
    /// Function: SetLevelLoaded
    /// </summary>
    public unsafe void SetLevelLoaded(BmSDK.FName LevelName, bool Loaded)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetLevelLoaded", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loaded, paramsPtr + 8);
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
    /// Function: SetPackageLevelLoaded
    /// </summary>
    public unsafe void SetPackageLevelLoaded(BmSDK.FString PackageName, bool Loaded)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetPackageLevelLoaded", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loaded, paramsPtr + 16);
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
    /// Function: AnyChatterSuppressingObjectsOfClass
    /// </summary>
    public unsafe bool AnyChatterSuppressingObjectsOfClass(BmSDK.Class ClassType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AnyChatterSuppressingObjectsOfClass", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClassType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: PrintObjectsSuppressingChatter
    /// </summary>
    public unsafe void PrintObjectsSuppressingChatter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PrintObjectsSuppressingChatter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetObjectsSuppressingChatter
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> GetObjectsSuppressingChatter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetObjectsSuppressingChatter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetChatterSuppression
    /// </summary>
    public unsafe void SetChatterSuppression(bool bSuppress, BmSDK.GameObject settingObject)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetChatterSuppression", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuppress, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(settingObject, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsChatterSuppressed
    /// </summary>
    public unsafe bool IsChatterSuppressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsChatterSuppressed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PrintObjectsSettingChaseInProgress
    /// </summary>
    public unsafe void PrintObjectsSettingChaseInProgress()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PrintObjectsSettingChaseInProgress", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetObjectsSettingChaseInProgress
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> GetObjectsSettingChaseInProgress()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetObjectsSettingChaseInProgress", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetChaseInProgress
    /// </summary>
    public unsafe void SetChaseInProgress(bool bInProgress, BmSDK.GameObject settingObject)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetChaseInProgress", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInProgress, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(settingObject, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetChaseInProgressObject
    /// </summary>
    public unsafe BmSDK.GameObject GetChaseInProgressObject()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetChaseInProgressObject", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsChaseInProgress
    /// </summary>
    public unsafe bool IsChaseInProgress()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsChaseInProgress", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: NotifyBMBLTeleported
    /// </summary>
    public unsafe void NotifyBMBLTeleported()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.NotifyBMBLTeleported", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WBPlayRewardsFlowEnabled
    /// </summary>
    public unsafe bool WBPlayRewardsFlowEnabled()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.WBPlayRewardsFlowEnabled", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: WBIDEnabled
    /// </summary>
    public unsafe bool WBIDEnabled()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.WBIDEnabled", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetWBPlayEmail
    /// </summary>
    public unsafe BmSDK.FString GetWBPlayEmail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetWBPlayEmail", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SignedInToWBPlay
    /// </summary>
    public unsafe bool SignedInToWBPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SignedInToWBPlay", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsFrontendChallengeMode
    /// </summary>
    public unsafe bool IsFrontendChallengeMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsFrontendChallengeMode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RemoveOldConversationActivations
    /// </summary>
    public unsafe void RemoveOldConversationActivations()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RemoveOldConversationActivations", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasConversationActivatedRecently
    /// </summary>
    public unsafe bool HasConversationActivatedRecently(BmSDK.FName inSpeechAssetName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HasConversationActivatedRecently", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inSpeechAssetName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: RegisterConversationActivation
    /// </summary>
    public unsafe void RegisterConversationActivation(BmSDK.FName inSpeechAssetName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RegisterConversationActivation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inSpeechAssetName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FreezeAttackDestroyTarget
    /// </summary>
    public unsafe void FreezeAttackDestroyTarget(BmSDK.BmGame.RVehicleNPC InTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FreezeAttackDestroyTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FRequiredChaptersByChallengeId
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRequiredChaptersByChallengeId
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Chapters
        /// </summary>
        public unsafe BmSDK.FString Chapters
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FChallengeCharacterId
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FChallengeCharacterId
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Override
        /// </summary>
        public unsafe BmSDK.FString Override
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FConversationActivationTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FConversationActivationTime
    {
        /// <summary>
        /// NameProperty: speechAssetName
        /// </summary>
        public unsafe BmSDK.FName speechAssetName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: lastActivatedTime
        /// </summary>
        public unsafe float lastActivatedTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FDofStruct
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FDofStruct
    {
        /// <summary>
        /// FloatProperty: ApertureStop
        /// </summary>
        public unsafe float ApertureStop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: FocusDistance
        /// </summary>
        public unsafe float FocusDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: InterpolationDuration
        /// </summary>
        public unsafe float InterpolationDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: BloomScale
        /// </summary>
        public unsafe float BloomScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bEnableDOF
        /// </summary>
        public unsafe bool bEnableDOF
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FVillainAttackInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FVillainAttackInfo
    {
        /// <summary>
        /// BoolProperty: bHitsLow
        /// </summary>
        public unsafe bool bHitsLow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bHitsHigh
        /// </summary>
        public unsafe bool bHitsHigh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Priority
        /// </summary>
        public unsafe int Priority
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: CounterLimb
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.CounterLimb CounterLimb
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CounterLimb>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeMirrored
        /// </summary>
        public unsafe bool bCanBeMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: AttackRange
        /// </summary>
        public unsafe float AttackRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: ForceHitDistance
        /// </summary>
        public unsafe float ForceHitDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: VillainStrikeBone
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.BoneNameList VillainStrikeBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.BoneNameList>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: PlayerImpactBone
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.BoneNameList PlayerImpactBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.BoneNameList>(Ptr + 25); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 25); }; }
        }

        /// <summary>
        /// FloatProperty: HitReactionSlideDistance
        /// </summary>
        public unsafe float HitReactionSlideDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: BoneNameList
    /// </summary>
    public enum BoneNameList
    {
        BONE_None = 0,
        BONE_Head = 1,
        BONE_Torso = 2,
        BONE_Pelvis = 3,
        BONE_L_Hand = 4,
        BONE_L_Elbow = 5,
        BONE_L_Foot = 6,
        BONE_L_Knee = 7,
        BONE_R_Hand = 8,
        BONE_R_Elbow = 9,
        BONE_R_Foot = 10,
        BONE_R_Knee = 11,
        BONE_BetweenHands = 12,
        BONE_MAX = 13,
    }

    /// <summary>
    /// Enum: CounterLimb
    /// </summary>
    public enum CounterLimb
    {
        ECL_None = 0,
        ECL_LeftArm = 1,
        ECL_RightArm = 2,
        ECL_LeftLeg = 3,
        ECL_RightLeg = 4,
        ECL_Pipe = 5,
        ECL_HarleyBat = 6,
        ECL_HeavySmash = 7,
        ECL_Custom = 8,
        ECL_NinjaSword = 9,
        ECL_Drone = 10,
        ECL_KnifeMultiDisarm = 11,
        ECL_NinjaSwordMultiDisarm = 12,
        ECL_NinjaSwordInAir = 13,
        ECL_RightArmMultiWeapon = 14,
        ECL_LeftArmRobot = 15,
        ECL_RightArmRobot = 16,
        ECL_LeftLegRobot = 17,
        ECL_RightLegRobot = 18,
        ECL_NinjaSwordInAirClose = 19,
        ECL_DisruptedStunStick = 20,
        ECL_LeftArmDollotron = 21,
        ECL_RightArmDollotron = 22,
        ECL_LeftLegDollotron = 23,
        ECL_RightLegDollotron = 24,
        ECL_MAX = 25,
    }

    /// <summary>
    /// Struct: FStoryDLCItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FStoryDLCItem
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: UISortId
        /// </summary>
        public unsafe int UISortId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: PersistentSaveSlotId
        /// </summary>
        public unsafe int PersistentSaveSlotId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StrProperty: BaseCharacter
        /// </summary>
        public unsafe BmSDK.FString BaseCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StrProperty: NewGameStart
        /// </summary>
        public unsafe BmSDK.FString NewGameStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FMapElementsItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FMapElementsItem
    {
        /// <summary>
        /// StrProperty: MapName
        /// </summary>
        public unsafe BmSDK.FString MapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ItemType
        /// </summary>
        public unsafe BmSDK.FString ItemType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: ItemName
        /// </summary>
        public unsafe BmSDK.FString ItemName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: CustomFlags
        /// </summary>
        public unsafe BmSDK.FString CustomFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: RevealChapterNum
        /// </summary>
        public unsafe int RevealChapterNum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// IntProperty: X
        /// </summary>
        public unsafe int X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// IntProperty: Y
        /// </summary>
        public unsafe int Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// IntProperty: Z
        /// </summary>
        public unsafe int Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// IntProperty: Rotation
        /// </summary>
        public unsafe int Rotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// IntProperty: FloatUpBy
        /// </summary>
        public unsafe int FloatUpBy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// IntProperty: Oxy
        /// </summary>
        public unsafe int Oxy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// IntProperty: Flags
        /// </summary>
        public unsafe int Flags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// ByteProperty: GroupArea
        /// </summary>
        public unsafe byte GroupArea
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// ByteProperty: GroupRange
        /// </summary>
        public unsafe byte GroupRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 97); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }; }
        }

        /// <summary>
        /// ByteProperty: Filter
        /// </summary>
        public unsafe byte Filter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 98); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 98); }; }
        }
    }

    /// <summary>
    /// Struct: FMapElements
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FMapElements
    {
        /// <summary>
        /// StrProperty: MapName
        /// </summary>
        public unsafe BmSDK.FString MapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Indicies
        /// </summary>
        public unsafe BmSDK.TArray<int> Indicies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FIndexDistItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FIndexDistItem
    {
        /// <summary>
        /// IntProperty: Index
        /// </summary>
        public unsafe int Index
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FMapHackOWLoc
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FMapHackOWLoc
    {
        /// <summary>
        /// StrProperty: SubName
        /// </summary>
        public unsafe BmSDK.FString SubName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ParentMapName
        /// </summary>
        public unsafe BmSDK.FString ParentMapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: X
        /// </summary>
        public unsafe int X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: Y
        /// </summary>
        public unsafe int Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: Z
        /// </summary>
        public unsafe int Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: SubX
        /// </summary>
        public unsafe int SubX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: SubY
        /// </summary>
        public unsafe int SubY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: SubZ
        /// </summary>
        public unsafe int SubZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StrProperty: FlagCheck
        /// </summary>
        public unsafe BmSDK.FString FlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bHasNoMap
        /// </summary>
        public unsafe bool bHasNoMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }
    }

    /// <summary>
    /// Struct: FLevelTransitionDesc
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FLevelTransitionDesc
    {
        /// <summary>
        /// StrProperty: LevelNameOwner
        /// </summary>
        public unsafe BmSDK.FString LevelNameOwner
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: LevelFront
        /// </summary>
        public unsafe int LevelFront
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: LevelBack
        /// </summary>
        public unsafe int LevelBack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: NextTransitionFront
        /// </summary>
        public unsafe int NextTransitionFront
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: NextTransitionBack
        /// </summary>
        public unsafe int NextTransitionBack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: Rotation
        /// </summary>
        public unsafe BmSDK.Rotator Rotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: Extent
        /// </summary>
        public unsafe System.Numerics.Vector3 Extent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StructProperty: LevelOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 LevelOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// BoolProperty: ActAsRcVisibilityBlocker
        /// </summary>
        public unsafe bool ActAsRcVisibilityBlocker
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }; }
        }
    }

    /// <summary>
    /// Struct: FLevelVolumeBsp
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FLevelVolumeBsp
    {
        /// <summary>
        /// StructProperty: Plane
        /// </summary>
        public unsafe BmSDK.GameObject.FPlane Plane
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FPlane>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ChildFront
        /// </summary>
        public unsafe int ChildFront
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: ChildBack
        /// </summary>
        public unsafe int ChildBack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FLevelVolumeDesc
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FLevelVolumeDesc
    {
        /// <summary>
        /// NameProperty: LevelName
        /// </summary>
        public unsafe BmSDK.FName LevelName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: LevelNameString
        /// </summary>
        public unsafe BmSDK.FString LevelNameString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Priority
        /// </summary>
        public unsafe int Priority
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: BspRoot
        /// </summary>
        public unsafe int BspRoot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: FirstTransition
        /// </summary>
        public unsafe int FirstTransition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: IsLoaded
        /// </summary>
        public unsafe bool IsLoaded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: IsVisible
        /// </summary>
        public unsafe bool IsVisible
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: IsCity
        /// </summary>
        public unsafe bool IsCity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: IsRcOverworld
        /// </summary>
        public unsafe bool IsRcOverworld
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: IsOverworld
        /// </summary>
        public unsafe bool IsOverworld
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: CanTeleportBatmobile
        /// </summary>
        public unsafe bool CanTeleportBatmobile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: CanTeleportBatmobileOut
        /// </summary>
        public unsafe bool CanTeleportBatmobileOut
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: NoVehicles
        /// </summary>
        public unsafe bool NoVehicles
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// ByteProperty: Standalone
        /// </summary>
        public unsafe byte Standalone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ByteProperty: CityDistrict
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EDistrict CityDistrict
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EDistrict>(Ptr + 41); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 41); }; }
        }

        /// <summary>
        /// StructProperty: Bounds
        /// </summary>
        public unsafe BmSDK.GameObject.FSimpleBox Bounds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSimpleBox>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: LevelOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 LevelOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// StructProperty: DistrictBoundaryPlane
        /// </summary>
        public unsafe BmSDK.GameObject.FPlane DistrictBoundaryPlane
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FPlane>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ByteProperty: DistrictBehindBoundaryPlane
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EDistrict DistrictBehindBoundaryPlane
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EDistrict>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
    }

    /// <summary>
    /// Struct: FMostWantedSetup
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FMostWantedSetup
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bStartLocked
        /// </summary>
        public unsafe bool bStartLocked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bIsDLC
        /// </summary>
        public unsafe bool bIsDLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: BioCharacter
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EBioCharacter BioCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EBioCharacter>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: Markers
        /// </summary>
        public unsafe BmSDK.TArray<byte> Markers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: MissionWeight
        /// </summary>
        public unsafe int MissionWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ArrayProperty: WaynetechPointsTotal
        /// </summary>
        public unsafe BmSDK.TArray<byte> WaynetechPointsTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ArrayProperty: Lips
        /// </summary>
        public unsafe BmSDK.TArray<byte> Lips
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// ArrayProperty: Lipsf
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Lipsf
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
    }

    /// <summary>
    /// Struct: FChallengeDesc
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FChallengeDesc
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: PackId
        /// </summary>
        public unsafe int PackId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardId
        /// </summary>
        public unsafe int LeaderboardId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: ChallengeFrontendGroup
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EChallengeFrontendGroup ChallengeFrontendGroup
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeFrontendGroup>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: ChallengeFrontendState
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EChallengeFrontendState ChallengeFrontendState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeFrontendState>(Ptr + 13); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13); }; }
        }

        /// <summary>
        /// ByteProperty: ChallengeBeaconStyle
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EChallengeBeaconStyle ChallengeBeaconStyle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeBeaconStyle>(Ptr + 14); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14); }; }
        }

        /// <summary>
        /// ByteProperty: ChallengeRankMode
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EChallengeRankMode ChallengeRankMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeRankMode>(Ptr + 15); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15); }; }
        }

        /// <summary>
        /// StructProperty: WorldLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 WorldLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: NavigationLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 NavigationLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StrProperty: PlayableCharacter
        /// </summary>
        public unsafe BmSDK.FString PlayableCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StrProperty: PlayableBatmobile
        /// </summary>
        public unsafe BmSDK.FString PlayableBatmobile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StrProperty: Prerequisite
        /// </summary>
        public unsafe BmSDK.FString Prerequisite
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// StrProperty: StartRef
        /// </summary>
        public unsafe BmSDK.FString StartRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// IntProperty: DifficultyLevel
        /// </summary>
        public unsafe int DifficultyLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// BoolProperty: IgnoreGameState
        /// </summary>
        public unsafe bool IgnoreGameState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }; }
        }

        /// <summary>
        /// ByteProperty: InstallChunkNeeded
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EInstallChunk InstallChunkNeeded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EInstallChunk>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
    }

    /// <summary>
    /// Struct: FMapCampaignEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FMapCampaignEntry
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: EStasisLevel
    /// </summary>
    public enum EStasisLevel
    {
        STASISLEVEL_Normal = 0,
        STASISLEVEL_Cheap = 1,
        STASISLEVEL_SuperCheap = 2,
        STASISLEVEL_MAX = 3,
    }

    /// <summary>
    /// Struct: FFilteredVehicleExclusionVolume
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FFilteredVehicleExclusionVolume
    {
        /// <summary>
        /// ObjectProperty: Volume
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleExclusionVolume Volume
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleExclusionVolume>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Bounds
        /// </summary>
        public unsafe BmSDK.GameObject.FBox Bounds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBox>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FVehicleScenarioInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FVehicleScenarioInfo
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Scenario
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleScenario Scenario
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleScenario>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: SpawnChance
        /// </summary>
        public unsafe float SpawnChance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: MinTimeBetweenSpawns
        /// </summary>
        public unsafe float MinTimeBetweenSpawns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: ExtendedTimeBetweenSpawns
        /// </summary>
        public unsafe float ExtendedTimeBetweenSpawns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: MaxActiveInstances
        /// </summary>
        public unsafe int MaxActiveInstances
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: bUseMaxInstances
        /// </summary>
        public unsafe byte bUseMaxInstances
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ByteProperty: bOnlyLimitSpawnFrequencyWhenSeen
        /// </summary>
        public unsafe byte bOnlyLimitSpawnFrequencyWhenSeen
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 29); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 29); }; }
        }

        /// <summary>
        /// ByteProperty: ScenarioType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.VehicleScenarioType ScenarioType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.VehicleScenarioType>(Ptr + 30); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 30); }; }
        }
    }

    /// <summary>
    /// Enum: DynamicPopulation_VehicleScenario_Version
    /// </summary>
    public enum DynamicPopulation_VehicleScenario_Version
    {
        DynamicPopulation_VehicleScenario_Initial = 0,
        DynamicPopulation_VehicleScenario_HasBeenSeen = 1,
        DynamicPopulation_VehicleScenario_ExtendedTimeBetweenSpawns = 2,
        DynamicPopulation_VehicleScenario_ScenarioType = 3,
        DynamicPopulation_VehicleScenario_MAX = 4,
    }

    /// <summary>
    /// Enum: VehicleScenarioType
    /// </summary>
    public enum VehicleScenarioType
    {
        VehicleScenario_None = 0,
        VehicleScenario_Drone = 1,
        VehicleScenario_Humvee = 2,
        VehicleScenario_Thug = 3,
        VehicleScenario_APC = 4,
        VehicleScenario_CopChase = 5,
        VehicleScenario_MAX = 6,
    }

    /// <summary>
    /// Struct: FVehicleInitInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FVehicleInitInfo
    {
        /// <summary>
        /// ObjectProperty: Abandoned
        /// </summary>
        public unsafe BmSDK.BmGame.RAbandonedVehicle Abandoned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAbandonedVehicle>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Stage
        /// </summary>
        public unsafe int Stage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FVehiclePassengerSpawnInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FVehiclePassengerSpawnInfo
    {
        /// <summary>
        /// ObjectProperty: Vehicle
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPC Vehicle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: PassengerIndex
        /// </summary>
        public unsafe int PassengerIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Spawner
        /// </summary>
        public unsafe BmSDK.BmGame.RBmPawnSpawner Spawner
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBmPawnSpawner>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Scenario
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleScenario Scenario
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleScenario>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: ScenarioVehicleIndex
        /// </summary>
        public unsafe int ScenarioVehicleIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FVehicleScenarioSpawnInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FVehicleScenarioSpawnInfo
    {
        /// <summary>
        /// ObjectProperty: Scenario
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleScenario Scenario
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleScenario>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SpawnLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 SpawnLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: SpawnRot
        /// </summary>
        public unsafe BmSDK.Rotator SpawnRot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: RoadWidth
        /// </summary>
        public unsafe float RoadWidth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: AddedFrame
        /// </summary>
        public unsafe int AddedFrame
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: ObeyExclusionZones
        /// </summary>
        public unsafe bool ObeyExclusionZones
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// ByteProperty: SpawnType
        /// </summary>
        public unsafe byte SpawnType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ArrayProperty: BehaviourVolumes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Volume> BehaviourVolumes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ObjectProperty: PatrolRoute
        /// </summary>
        public unsafe BmSDK.BmGame.RPatrolPoint PatrolRoute
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// ArrayProperty: SpawnedVehicles
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> SpawnedVehicles
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC>>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Struct: FEnterVehicleAnimInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FEnterVehicleAnimInfo
    {
        /// <summary>
        /// NameProperty: AnimName
        /// </summary>
        public unsafe BmSDK.FName AnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: AnimNameDoor
        /// </summary>
        public unsafe BmSDK.FName AnimNameDoor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bMirrored
        /// </summary>
        public unsafe bool bMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// NameProperty: AnimSocket
        /// </summary>
        public unsafe BmSDK.FName AnimSocket
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// NameProperty: ActualSocket
        /// </summary>
        public unsafe BmSDK.FName ActualSocket
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FExitVehicleSlotInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FExitVehicleSlotInfo
    {
        /// <summary>
        /// ByteProperty: VehicleOrientation
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EVehicleOrientation VehicleOrientation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EVehicleOrientation>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: AnimInfo
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FExitVehicleAnimationInfo AnimInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FExitVehicleAnimationInfo>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: DependentOnPassengerID
        /// </summary>
        public unsafe int DependentOnPassengerID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// ObjectProperty: DependentOnPassengerPawn
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI DependentOnPassengerPawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bDefaultExitAnim
        /// </summary>
        public unsafe bool bDefaultExitAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bLowPriorityExitAnim
        /// </summary>
        public unsafe bool bLowPriorityExitAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeUsedWhenDazed
        /// </summary>
        public unsafe bool bCanBeUsedWhenDazed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeUsedWhenCalm
        /// </summary>
        public unsafe bool bCanBeUsedWhenCalm
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Struct: FExitVehicleAnimationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FExitVehicleAnimationInfo
    {
        /// <summary>
        /// NameProperty: AnimName
        /// </summary>
        public unsafe BmSDK.FName AnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: AnimNameDoor
        /// </summary>
        public unsafe BmSDK.FName AnimNameDoor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bMirrored
        /// </summary>
        public unsafe bool bMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// NameProperty: AnimSocket
        /// </summary>
        public unsafe BmSDK.FName AnimSocket
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// NameProperty: ActualSocket
        /// </summary>
        public unsafe BmSDK.FName ActualSocket
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bNoStarsOnRagdoll
        /// </summary>
        public unsafe bool bNoStarsOnRagdoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// NameProperty: UnconsciousAnim
        /// </summary>
        public unsafe BmSDK.FName UnconsciousAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Enum: EVehicleOrientation
    /// </summary>
    public enum EVehicleOrientation
    {
        VEHICLE_Upright = 0,
        VEHICLE_OnRoof = 1,
        VEHICLE_LeftSide = 2,
        VEHICLE_RightSide = 3,
        VEHICLE_Invalid = 4,
        VEHICLE_MAX = 5,
    }

    /// <summary>
    /// Struct: FFloorCorrectionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FFloorCorrectionConfig
    {
        /// <summary>
        /// StructProperty: Standing
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig Standing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Moving
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig Moving
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: OnCeiling
        /// </summary>
        public unsafe bool OnCeiling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: CatwomanCrawlingHack
        /// </summary>
        public unsafe bool CatwomanCrawlingHack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FFloorMovementCorrectionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FFloorMovementCorrectionConfig
    {
        /// <summary>
        /// FloatProperty: Along
        /// </summary>
        public unsafe float Along
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Up
        /// </summary>
        public unsafe float Up
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Down
        /// </summary>
        public unsafe float Down
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Orientation
        /// </summary>
        public unsafe float Orientation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: OrientationPivotZ
        /// </summary>
        public unsafe float OrientationPivotZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FVisibilityResult
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FVisibilityResult
    {
        /// <summary>
        /// BoolProperty: bPartiallyOffScreen
        /// </summary>
        public unsafe bool bPartiallyOffScreen
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIsTooSmall
        /// </summary>
        public unsafe bool bIsTooSmall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIsObscured
        /// </summary>
        public unsafe bool bIsObscured
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bProjectedNotAligned
        /// </summary>
        public unsafe bool bProjectedNotAligned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bProjectedPartial
        /// </summary>
        public unsafe bool bProjectedPartial
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: PartiallyScanned
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RRiddleBase> PartiallyScanned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRiddleBase>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FRWindState
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRWindState
    {
        /// <summary>
        /// StructProperty: WindVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 WindVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SourceVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 SourceVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: SourceAcceleration
        /// </summary>
        public unsafe System.Numerics.Vector3 SourceAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: TargetVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: TargetAcceleration
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: TotalInterpolationTime
        /// </summary>
        public unsafe float TotalInterpolationTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: RemainingInterpolationTime
        /// </summary>
        public unsafe float RemainingInterpolationTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FRWindConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRWindConfig
    {
        /// <summary>
        /// BoolProperty: IsApplyWind
        /// </summary>
        public unsafe bool IsApplyWind
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WindVelocityCentre
        /// </summary>
        public unsafe System.Numerics.Vector3 WindVelocityCentre
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: WindVelocityRadius
        /// </summary>
        public unsafe float WindVelocityRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MaxWindAccelerationRadius
        /// </summary>
        public unsafe float MaxWindAccelerationRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MinTargetChangePeriod
        /// </summary>
        public unsafe float MinTargetChangePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxTargetChangePeriod
        /// </summary>
        public unsafe float MaxTargetChangePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: WindForceCoefficient
        /// </summary>
        public unsafe float WindForceCoefficient
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FRBasicWindConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRBasicWindConfig
    {
        /// <summary>
        /// BoolProperty: IsApplyWind
        /// </summary>
        public unsafe bool IsApplyWind
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WindDirection
        /// </summary>
        public unsafe System.Numerics.Vector3 WindDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: WindBlusteryness
        /// </summary>
        public unsafe float WindBlusteryness
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FMovementControllerHistory
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FMovementControllerHistory
    {
        /// <summary>
        /// StructProperty: Direction
        /// </summary>
        public unsafe System.Numerics.Vector3 Direction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: InputSpeed
        /// </summary>
        public unsafe float InputSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: eSideStoryCooldownTimer
    /// </summary>
    public enum eSideStoryCooldownTimer
    {
        eSSCT_Firefly = 0,
        eSSCT_Penguin = 1,
        eSSCT_Bank = 2,
        eSSCT_MAX = 3,
    }

    /// <summary>
    /// Enum: FenceJumpEdgeType
    /// </summary>
    public enum FenceJumpEdgeType
    {
        FENCEEDGE_None = 0,
        FENCEEDGE_Drop = 1,
        FENCEEDGE_Climb = 2,
        FENCEEDGE_Level = 3,
        FENCEEDGE_Level256 = 4,
        FENCEEDGE_Level384 = 5,
        FENCEEDGE_MinigunClimb = 6,
        FENCEEDGE_MinigunClimb_384_Gap = 7,
        FENCEEDGE_MinigunClimb_2 = 8,
        FENCEEDGE_MinigunDrop = 9,
        FENCEEDGE_MinigunDrop_2 = 10,
        FENCEEDGE_CarBonnetJump = 11,
        FENCEEDGE_CarRoofJump = 12,
        STEPEDGE_Drop = 13,
        STEPEDGE_Climb = 14,
        STEPEDGE_MinigunDrop = 15,
        STEPEDGE_MinigunDrop_2 = 16,
        STEPEDGE_MinigunClimb = 17,
        STEPEDGE_MinigunClimb_384_Gap = 18,
        STEPEDGE_MinigunClimb_2 = 19,
        FenceJumpEdgeType_MAX = 20,
    }

    /// <summary>
    /// Enum: EClimbEdgeFailReason
    /// </summary>
    public enum EClimbEdgeFailReason
    {
        ECLIMBFAIL_None = 0,
        ECLIMBFAIL_FlagNotSet = 1,
        ECLIMBFAIL_WidthDepthFail = 2,
        ECLIMBFAIL_WidthFail = 3,
        ECLIMBFAIL_DepthFail = 4,
        ECLIMBFAIL_HeightMatchNotFound = 5,
        ECLIMBFAIL_NavMeshPolyFind = 6,
        ECLIMBFAIL_FloorFind = 7,
        ECLIMBFAIL_FloorTooFar = 8,
        ECLIMBFAIL_PostSubMeshUpdateNavMeshPolyFind = 9,
        RCLIMBFAIL_PostSubMeshUpdateNoSourceSpans = 10,
        ECLIMBFAIL_PostSubMeshUpdateNoEdgesAdded = 11,
        ECLIMBFAIL_PostSubMeshUpdateNoDestSpans = 12,
        ECLIMBFAIL_PylonMismatch = 13,
        ECLIMBFAIL_NavMeshShuttingDown = 14,
        EClimbEdgeFailReason_MAX = 15,
    }

    /// <summary>
    /// Enum: StrikeRange
    /// </summary>
    public enum StrikeRange
    {
        SR_None = 0,
        SR_Close = 1,
        SR_Far = 2,
        SR_VeryClose = 3,
        SR_MAX = 4,
    }

    /// <summary>
    /// Enum: StrikeDirection
    /// </summary>
    public enum StrikeDirection
    {
        SD_None = 0,
        SD_Front = 1,
        SD_Back = 2,
        SD_Left = 3,
        SD_Right = 4,
        SD_MAX = 5,
    }

    /// <summary>
    /// Enum: StrikeStrength
    /// </summary>
    public enum StrikeStrength
    {
        SS_None = 0,
        SS_WeakAndStrong = 1,
        SS_Weak = 2,
        SS_Strong = 3,
        SS_Stun = 4,
        SS_Run = 5,
        SS_BeatdownStart = 6,
        SS_Beatdown = 7,
        SS_BeatdownEnd = 8,
        SS_BeatdownEndEnv = 9,
        SS_SuperStun = 10,
        SS_SuperStunEnd = 11,
        SS_AirStrikeEnd = 12,
        SS_AirStrikeEndHigh = 13,
        SS_Floor = 14,
        SS_Barge = 15,
        SS_Multi = 16,
        SS_BatBreak = 17,
        SS_BeatdownRobotEnd = 18,
        SS_BeatdownRobotEndEnv = 19,
        SS_BeatdownElectricFence = 20,
        SS_MAX = 21,
    }

    /// <summary>
    /// Enum: EStealthTakeDownStages
    /// </summary>
    public enum EStealthTakeDownStages
    {
        ESTDS_CornerGrab = 0,
        ESTDS_FallingTakeDown = 1,
        ESTDS_GlassAttack = 2,
        ESTDS_GrabFromCrouch = 3,
        ESTDS_GrabFromCrouchAware = 4,
        ESTDS_GrabFromHang = 5,
        ESTDS_GrabOnFloor = 6,
        ESTDS_LedgeAttack = 7,
        ESTDS_DoubleLedgeAttack = 8,
        ESTDS_RailingAttack = 9,
        ESTDS_SneakyCombatTakeDown = 10,
        ESTDS_ReverseChokeAttack = 11,
        ESTDS_DoubleHead = 12,
        ESTDS_FromAbove = 13,
        ESTDS_FromAboveEnd = 14,
        ESTDS_FromAboveOnSpotEnd = 15,
        ESTDS_FromAboveQuickEnd = 16,
        ESTDS_LineLauncherTakeDown = 17,
        ESTDS_CwInvertedFromCeilingGrab = 18,
        ESTDS_CwInvertedFromCeilingEnd = 19,
        ESTDS_CwInvertedFromCeilingSuccess = 20,
        ESTDS_FractureWallTakeDown = 21,
        ESTDS_CwPullFromCatwalk = 22,
        ESTDS_TunnelGrateGrab = 23,
        ESTDS_VentAttack = 24,
        ESTDS_BoostGlideTackle = 25,
        ESTDS_SuperGlideTakedown = 26,
        ESTDS_GrappleBoostTakedown = 27,
        ESTDS_LineLauncherAttack = 28,
        ESTDS_LongRangeLedgeTakedown = 29,
        ESTDS_LongRangeLedgeTakedownSuccess = 30,
        ESTDS_LongRangeRailingTakedown = 31,
        ESTDS_StandingQuickTakedown = 32,
        ESTDS_HangingFearFinish = 33,
        ESTDS_GlassTakedownFinish = 34,
        ESTDS_ReverseChokeFinish = 35,
        ESTDS_TunnelGrateEnd = 36,
        ESTDS_TunnelGrateGrabAlignedFinish = 37,
        ESTDS_GrateInvertedTakedown = 38,
        ESTDS_GrateInvertedTakedownEnd = 39,
        ESTDS_DoubleTeamFinish = 40,
        ESTDS_DoubleTeamFail = 41,
        ESTDS_DoubleTunnelGrateGrab = 42,
        ESTDS_DoubleTunnelGrateEnd = 43,
        ESTDS_DoubleGrabFromHang = 44,
        ESTDS_DoubleHangingFearFinish = 45,
        ESTDS_HidePointGrateAbove = 46,
        ESTDS_HidePointGrateAboveEnd = 47,
        ESTDS_RailingFearToLedge = 48,
        ESTDS_RailingFearToStand = 49,
        ESTDS_SpecialChainTakedown_Loop = 50,
        ESTDS_DualPlayOrderedTakedown = 51,
        ESTDS_GrabFromGlide = 52,
        ESTDS_DropToGrabHopOffLedgeStart = 53,
        ESTDS_DropToGrab = 54,
        ESTDS_DropThroughCeilingGrateFinish = 55,
        ESTDS_LedgeHangDropToGrab = 56,
        ESTDS_CornerCoverQuickTakedown = 57,
        ESTDS_TeleportGrateAttack = 58,
        ESTDS_IceSmash = 59,
        ESTDS_HqSnareTrapTakedown = 60,
        ESTDS_BgScaredTakedownTunnelGrateGrab = 61,
        ESTDS_BgScaredTakedownFromAbove = 62,
        ESTDS_BgScaredTakedownDropToGrabHopOffLedgeStart = 63,
        ESTDS_BgScaredSuperGlideTakedown = 64,
        ESTDS_BgScaredSneakyCombatTakeDown = 65,
        ESTDS_BgScaredRaillingAttack = 66,
        ESTDS_BgScareFractureWallTakeDown = 67,
        ESTDS_StealthTakeDownStageMAX = 68,
        ESTDS_MAX = 69,
    }

    /// <summary>
    /// Enum: GameCombatCameraType
    /// </summary>
    public enum GameCombatCameraType
    {
        GCCT_BrawlComatCamera = 0,
        GCCT_CorridorCombatCamera = 1,
        GCCT_HighCombatCamera = 2,
        GCCT_NightWingBossFightCamera = 3,
        GCCT_MAX = 4,
    }

    /// <summary>
    /// Struct: FSoundSurface
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FSoundSurface
    {
        /// <summary>
        /// ObjectProperty: SurfaceType
        /// </summary>
        public unsafe BmSDK.Engine.AkSwitchName SurfaceType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: CameraLookAtSpeed
    /// </summary>
    public enum CameraLookAtSpeed
    {
        CLASP_Slow = 0,
        CLASP_Fast = 1,
        CLASP_Faster = 2,
        CLASP_VeryFast = 3,
        CLASP_VerySlow = 4,
        CLASP_Driving = 5,
        CLASP_Donuts = 6,
        CLASP_MAX = 7,
    }

    /// <summary>
    /// Enum: CameraLookAtStrength
    /// </summary>
    public enum CameraLookAtStrength
    {
        CLAS_ForceCamera = 0,
        CLAS_ForceUntilLookAtNeutral = 1,
        CLAS_LookAtWeakNoDrag = 2,
        CLAS_LookAtWeak = 3,
        CLAS_MAX = 4,
    }

    /// <summary>
    /// Enum: CameraLookAtType
    /// </summary>
    public enum CameraLookAtType
    {
        CLAT_NoLookAt = 0,
        CLAT_LookAtRotation = 1,
        CLAT_LookAtLocation = 2,
        CLAT_LookAtActor = 3,
        CLAT_MAX = 4,
    }

    /// <summary>
    /// Enum: ECombatLockType
    /// </summary>
    public enum ECombatLockType
    {
        ECLT_None = 0,
        ECLT_Thugs = 1,
        ECLT_Vehicles = 2,
        ECLT_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeModifiers
    /// </summary>
    public enum EChallengeModifiers
    {
        CMod_None = 0,
        CMod_Neg_ExtremeEnemies = 1,
        CMod_Neg_TimeLimit = 2,
        CMod_Neg_IncreasedAggression = 3,
        CMod_Neg_DecreasedHealth = 4,
        CMod_Neg_ProtectiveAura = 5,
        CMod_Neg_DangerZones = 6,
        CMod_Neg_OneHandTied = 7,
        CMod_Neg_ScatteredWeapons = 8,
        CMod_Pos_ReplenishingHealth = 9,
        CMod_Pos_TakedownProjectiles = 10,
        CMod_Pos_SuperPowered = 11,
        CMod_Pos_FreeMedal = 12,
        CMod_MAX = 13,
    }

    /// <summary>
    /// Enum: EChallengeModifierType
    /// </summary>
    public enum EChallengeModifierType
    {
        EChallengeModifier_None = 0,
        EChallengeModifier_Example1 = 1,
        EChallengeModifier_Example2 = 2,
        EChallengeModifier_MAX = 3,
    }

    /// <summary>
    /// Enum: EAchievementID
    /// </summary>
    public enum EAchievementID
    {
        EACID_None = 0,
        EACID_MP_A_Battle_Within = 1,
        EACID_MP_A_Heart_Broken_in_Two = 2,
        EACID_OT_Absolution = 3,
        EACID_MW_Angel_in_the_Dark = 4,
        EACID_MP_As_the_Crow_Flies = 5,
        EACID_MP_Be_Not_Afraid = 6,
        EACID_MW_Beautiful_Boy = 7,
        EACID_OT_Black_and_White = 8,
        EACID_MW_Blind_Love = 9,
        EACID_OT_Blunt_Trauma = 10,
        EACID_MP_Brothers_in_Arms = 11,
        EACID_MP_City_of_Fear = 12,
        EACID_MP_Cold_World = 13,
        EACID_MP_Creature_of_the_Night = 14,
        EACID_OT_Cycle_of_Violence = 15,
        EACID_MW_Dark_Allegiances = 16,
        EACID_MP_Dark_Wings_Fly_Away_in_Fear = 17,
        EACID_MW_Days_of_Fire = 18,
        EACID_OT_Dead_to_Rights = 19,
        EACID_OT_Death_and_Glory = 20,
        EACID_RI_Death_by_Design = 21,
        EACID_MW_Death_of_Innocents = 22,
        EACID_MW_Double_Jeopardy = 23,
        EACID_OT_Dreamland = 24,
        EACID_MP_Fear_of_Faith = 25,
        EACID_MP_Fear_of_Success = 26,
        EACID_OT_Fortunate_Son = 27,
        EACID_MW_Gates_of_Gotham = 28,
        EACID_OT_Gotham_After_Midnight = 29,
        EACID_MW_Gotham_Underground = 30,
        EACID_MW_Jekyll_and_Hyde = 31,
        EACID_MP_Journey_into_Knight = 32,
        EACID_MP_Judgement_Day = 33,
        EACID_MP_Knightfall = 34,
        EACID_RI_Lethal_Pursuits = 35,
        EACID_MP_Living_Hell = 36,
        EACID_MW_Manhunt = 37,
        EACID_MP_Master_of_Fear = 38,
        EACID_RI_Nine_Lives = 39,
        EACID_MP_No_Mans_Land = 40,
        EACID_RI_Pieces_of_the_Puzzle = 41,
        EACID_MW_Practice_Run = 42,
        EACID_RI_Riddle_Me_That = 43,
        EACID_RI_Riddler_on_the_Rampage = 44,
        EACID_RI_Riddles_in_the_Dark = 45,
        EACID_OT_Rite_of_Passage = 46,
        EACID_MW_Scar_of_the_Bat = 47,
        EACID_OT_Seduction_of_the_Gun = 48,
        EACID_OT_Sins_of_Youth = 49,
        EACID_MP_Strange_Deadfellows = 50,
        EACID_MW_Streets_of_Gotham = 51,
        EACID_RI_The_Burning_Question = 52,
        EACID_MW_The_Cult = 53,
        EACID_MP_The_Frequency_of_Fear = 54,
        EACID_MP_The_Long_Halloween = 55,
        EACID_RI_The_Primal_Riddle = 56,
        EACID_OT_The_Real_Deal = 57,
        EACID_RI_The_Riddle_Factory = 58,
        EACID_RI_The_Riddle_Unanswered = 59,
        EACID_MW_The_Road_Home = 60,
        EACID_RI_The_Road_to_Hell = 61,
        EACID_OT_The_Twilight_Kingdom = 62,
        EACID_MW_Touch_of_Death = 63,
        EACID_MP_Trail_of_Fear = 64,
        EACID_MW_Two_Faces_of_Fear = 65,
        EACID_MW_Two_Sides_of_the_Same_Coin = 66,
        EACID_OT_Unseen = 67,
        EACID_MP_Who_Rules_The_Night = 68,
        EACID_MP_With_a_Vengeance = 69,
        EACID_DLCBatGirl_Colletable = 70,
        EACID_DLCBatGirl_HostageFerrisWheel = 71,
        EACID_DLCBatGirl_HostageMerryGoRound = 72,
        EACID_DLCBatGirl_HostageGhostShip = 73,
        EACID_DLCBatGirl_JokerDefeated = 74,
        EACID_DLCBatGirl_ScareHackThugDefeated = 75,
        EACID_DLCBatGirl_HackingThugDefeated = 76,
        EACID_DLCBatGirl_HiddenTapes = 77,
        EACID_DLCHarley_NightwingDefeated = 78,
        EACID_DLCRedhood_BlackMaskDefeated = 79,
        EACID_DLCScarecrow_AllRacesCompleted = 80,
        EACID_DLCBmobBurton_Street_Demonz = 81,
        EACID_DLCBmobBurton_Gears_of_Justice = 82,
        EACID_DLCBmobBurton_Slayride = 83,
        EACID_DLCRobin_The_Big_Leagues = 84,
        EACID_DLCRobin_Search_For_A_Hero = 85,
        EACID_DLCNightwing_Acts_of_Violence = 86,
        EACID_DLCNightwing_Child_of_Justice = 87,
        EACID_DLCCatwoman_Relentless = 88,
        EACID_DLCCatwoman_Fight_or_Flight = 89,
        EACID_DLCAzrael_Shock_and_Awe = 90,
        EACID_DLCAzrael_Blood_Simple = 91,
        EACID_DLCBatgirl_Motherlode = 92,
        EACID_DLCBatgirl_Collateral_Damage = 93,
        EACID_DLCBmobClassic_A_Cut_Above = 94,
        EACID_DLCBmobClassic_Joy_Ride = 95,
        EACID_DLCBmobClassic_Road_to_Nowhere = 96,
        EACID_DLCBmobSnyder_The_Worlds_Finest = 97,
        EACID_DLCBmobSnyder_Ascension = 98,
        EACID_DLCBmobSnyder_Protege = 99,
        EACID_DLCBmobTumbler_Gangland_Express = 100,
        EACID_DLCBmobTumbler_Time_And_Motion = 101,
        EACID_DLCBmobTumbler_Rampant = 102,
        EACID_DLCStoryCatwoman_Final_Jeopardy = 103,
        EACID_DLCStoryGCPD_Rough_Justice = 104,
        EACID_DLCRedhood_Higher_Learning = 105,
        EACID_DLCRedhood_Baptism = 106,
        EACID_DLCVillainRas_The_Demon_Lives_Again = 107,
        EACID_DLCVillainRas_Daughter_Of_The_Demon = 108,
        EACID_DLCVillainRas_Ashes_To_Ashes = 109,
        EACID_DLCVillainHatter_The_Scene_Of_The_Crime = 110,
        EACID_DLCVillainHatter_Mind_Games = 111,
        EACID_DLCVillainHatter_In_Storybook_Endings = 112,
        EACID_DLCStoryTwoFace_Succession_Plans = 113,
        EACID_DLCHarley_Vengeance_Unlimited = 114,
        EACID_DLCHarley_Welcome_To_The_Party = 115,
        EACID_DLCVillainFreeze_Cold_Case = 116,
        EACID_DLCVillainFreeze_Out_In_The_Cold = 117,
        EACID_DLCVillainFreeze_The_Resurrection_And_The_Life = 118,
        EACID_DLCVillainCroc_Blood_In_The_Water = 119,
        EACID_DLCVillainCroc_The_Beast_Beneath = 120,
        EACID_DLCVillainCroc_Breaking_The_Skin = 121,
        EACID_DLCVillainCroc_Evolution = 122,
        EACID_DLCBmobArkham_Life_After_Death = 123,
        EACID_DLCWhat_the_Butler_Saw = 124,
        EACID_DLCSecrets_of_the_Batcave = 125,
        EACID_DLCSilent_Night_Deadly_Night = 126,
        EACID_DLCEternal = 127,
        EACID_DLCThe_Chill_in_the_Air = 128,
        EACID_DLCThe_Curtain_Falls = 129,
        EACID_DLCRequiem_for_a_Killer = 130,
        EACID_MAX = 131,
    }

    /// <summary>
    /// Enum: SContexts
    /// </summary>
    public enum SContexts
    {
        SContexts_OVERWORLD = 0,
        SContexts_COURT = 1,
        SContexts_CHURCH = 2,
        SContexts_STEEL = 3,
        SContexts_MUSEUM = 4,
        SContexts_UNDERWORLD = 5,
        SContexts_GCPD = 6,
        SContexts_RIDDLER = 7,
        SContexts_IVYLAIR = 8,
        SContexts_CW = 9,
        SContexts_ZSASZ = 10,
        SContexts_NORA = 11,
        SContexts_MADHATTER = 12,
        SContexts_BANE = 13,
        SContexts_HUSH = 14,
        SContexts_MAX = 15,
    }

    /// <summary>
    /// Enum: EContexts
    /// </summary>
    public enum EContexts
    {
        EContexts_CHALLENGE = 0,
        EContexts_Nothing = 1,
        EContexts_CHALLENGETYPE = 2,
        EContexts_STORYTYPE = 3,
        EContexts_Replay = 4,
        EContexts_EPISODETYPE = 5,
        EContexts_MAX = 6,
    }

    /// <summary>
    /// Enum: EPresenceID
    /// </summary>
    public enum EPresenceID
    {
        EPresence_Idle = 0,
        EPresence_Frontend = 1,
        EPresence_Story = 2,
        EPresence_Challenge = 3,
        EPresence_Replay = 4,
        EPresence_ArkhamEpisode = 5,
        EPresence_MAX = 6,
    }

    /// <summary>
    /// Enum: EBioCharacter
    /// </summary>
    public enum EBioCharacter
    {
        BioCharacter_Aaron_Cash = 0,
        BioCharacter_Albert_King = 1,
        BioCharacter_Alfred = 2,
        BioCharacter_Arkham_Knight = 3,
        BioCharacter_Azrael = 4,
        BioCharacter_Batman = 5,
        BioCharacter_Bruce_Wayne = 6,
        BioCharacter_Catwoman = 7,
        BioCharacter_Christina_Bell = 8,
        BioCharacter_Deacon_Blackfire = 9,
        BioCharacter_Deathstroke = 10,
        BioCharacter_Fire_Chief = 11,
        BioCharacter_Firefly = 12,
        BioCharacter_Gordon = 13,
        BioCharacter_Harley_Quinn = 14,
        BioCharacter_Henry_Adams = 15,
        BioCharacter_Hush = 16,
        BioCharacter_Jack_Ryder = 17,
        BioCharacter_Jason_Todd = 18,
        BioCharacter_Johnny_Charisma = 19,
        BioCharacter_Joker = 20,
        BioCharacter_Kirk_And_Francine_Langstrom = 21,
        BioCharacter_Lucius_Fox = 22,
        BioCharacter_ManBat = 23,
        BioCharacter_Martha_Wayne = 24,
        BioCharacter_Nightwing = 25,
        BioCharacter_Oracle = 26,
        BioCharacter_Penguin = 27,
        BioCharacter_Poison_Ivy = 28,
        BioCharacter_Professor_Pyg = 29,
        BioCharacter_RedHood = 30,
        BioCharacter_Riddler = 31,
        BioCharacter_Robin = 32,
        BioCharacter_Scarecrow = 33,
        BioCharacter_Simon_Stagg = 34,
        BioCharacter_Batgirl = 35,
        BioCharacter_Two_Face = 36,
        BioCharacter_Vicki_Vale = 37,
        BioCharacter_MAX = 38,
    }

    /// <summary>
    /// Enum: EComboMoveType
    /// </summary>
    public enum EComboMoveType
    {
        ECMT_Strike = 0,
        ECMT_CriticalStrike = 1,
        ECMT_Counter = 2,
        ECMT_CriticalCounter = 3,
        ECMT_Stun = 4,
        ECMT_SuperStun = 5,
        ECMT_Evade = 6,
        ECMT_Redirect = 7,
        ECMT_ProjectileCounter = 8,
        ECMT_AerialAttack = 9,
        ECMT_DirectedAerialAttack = 10,
        ECMT_GroundTakedown = 11,
        ECMT_BeatdownStart = 12,
        ECMT_BeatdownStrike = 13,
        ECMT_BeatdownFinish = 14,
        ECMT_BladeComboCounter = 15,
        ECMT_SuperBladeComboCounter = 16,
        ECMT_ElectricFloor = 17,
        ECMT_Takedown = 18,
        ECMT_Batarang = 19,
        ECMT_Batclaw = 20,
        ECMT_BatclawSlam = 21,
        ECMT_SmokePellet = 22,
        ECMT_REC = 23,
        ECMT_Freeze = 24,
        ECMT_Gel = 25,
        ECMT_BMDisarmAndDestroy = 26,
        ECMT_BMBatswarm = 27,
        ECMT_BMGroupGroundKO = 28,
        ECMT_CWProjectile = 29,
        ECMT_CWBullwhip = 30,
        ECMT_CWGroupTrip = 31,
        ECMT_CWGroupAttack = 32,
        ECMT_CWCaltrops = 33,
        ECMT_RBProjectile = 34,
        ECMT_RBStickyBomb = 35,
        ECMT_RBZipKick = 36,
        ECMT_RBShieldCharge = 37,
        ECMT_RBThrow = 38,
        ECMT_RBThrowRingOut = 39,
        ECMT_RBThrowKnockdown = 40,
        ECMT_RBGroupAttack = 41,
        ECMT_NWProjectile = 42,
        ECMT_NWGroupElectrify = 43,
        ECMT_NWGroupAttack = 44,
        ECMT_NWGroupStun = 45,
        ECMT_NWDart = 46,
        ECMT_NWDartHeadShot = 47,
        ECMT_NWStick = 48,
        ECMT_Slide = 49,
        ECMT_GroundStrike = 50,
        ECMT_GroundPickup = 51,
        ECMT_AerialJuggle = 52,
        ECMT_BatclawRedirect = 53,
        ECMT_PhysicsImpact = 54,
        ECMT_BatarangCharger = 55,
        ECMT_BMWeaponSnatch = 56,
        ECMT_EnvironmentTakedown = 57,
        ECMT_CriticalBeatdown = 58,
        ECMT_CriticalBeatdownFinish = 59,
        ECMT_ChargerRedirect = 60,
        ECMT_BatmobileTakedown = 61,
        ECMT_DualTakedown = 62,
        ECMT_SuperComboBatarang = 63,
        ECMT_SuperComboBatclaw = 64,
        ECMT_SuperComboGel = 65,
        ECMT_SuperComboREC = 66,
        ECMT_SuperComboFreeze = 67,
        ECMT_DodgedStrike = 68,
        ECMT_HQSnareTrap = 69,
        ECMT_RHDualHandguns = 70,
        ECMT_Max = 71,
    }

    /// <summary>
    /// Enum: RagdollStunType
    /// </summary>
    public enum RagdollStunType
    {
        RAGSTUN_Generic = 0,
        RAGSTUN_Batarang = 1,
        RAGSTUN_BatClaw = 2,
        RAGSTUN_GlideKick = 3,
        RAGSTUN_LineLaunchKick = 4,
        RAGSTUN_SwingKick = 5,
        RAGSTUN_Throw = 6,
        RAGSTUN_PounceAttack = 7,
        RAGSTUN_CaltropsTrap = 8,
        RAGSTUN_BoomerangBatarang = 9,
        RAGSTUN_DropAttack = 10,
        RAGSTUN_GelWeaponCrate = 11,
        RAGSTUN_SlideAttack = 12,
        RAGSTUN_GlideBoostTackle = 13,
        RAGSTUN_ControllableBatarang = 14,
        RAGSTUN_GelMine = 15,
        RAGSTUN_RECArmouredBlast = 16,
        RAGSTUN_RicochetStick = 17,
        RAGSTUN_ElectroBlast = 18,
        RAGSTUN_WristDart = 19,
        RAGSTUN_ShieldBash = 20,
        RAGSTUN_ShieldBlockAndBash = 21,
        RAGSTUN_ZipKick = 22,
        RAGSTUN_StickyBomb = 23,
        RAGSTUN_RasFade = 24,
        RAGSTUN_WhipTrip = 25,
        RAGSTUN_FreezeLadder = 26,
        RAGSTUN_IceThugPush = 27,
        RAGSTUN_BatmobileRiotSuppressor = 28,
        RAGSTUN_MAX = 29,
    }

    /// <summary>
    /// Struct: FGameActionToAAITakedownMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FGameActionToAAITakedownMapping
    {
        /// <summary>
        /// ArrayProperty: Actions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> Actions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: takedownType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.AAITakedownType takedownType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.AAITakedownType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: EGameAction
    /// </summary>
    public enum EGameAction
    {
        GA_None = 0,
        GA_Takedown_CombatTakedown = 1,
        GA_Takedown_CombatRedirect = 2,
        GA_Takedown_CombatRailing = 3,
        GA_Takedown_CombatStrike = 4,
        GA_Takedown_CombatWall = 5,
        GA_Takedown_CombatShocked = 6,
        GA_Takedown_Fallen = 7,
        GA_Takedown_GrabStanding = 8,
        GA_Takedown_GrabFloor = 9,
        GA_Takedown_GrabGrate = 10,
        GA_Takedown_GrabCorner = 11,
        GA_Takedown_HangAttack = 12,
        GA_Takedown_GlideKick = 13,
        GA_Takedown_GlassAttack = 14,
        GA_Takedown_VentAttack = 15,
        GA_Takedown_DropToGrab = 16,
        GA_Takedown_LedgeAttack = 17,
        GA_Takedown_Escape = 18,
        GA_KO = 19,
        GA_KO_Knife = 20,
        GA_KO_Pipe = 21,
        GA_KO_StunStick = 22,
        GA_KO_Shield = 23,
        GA_KO_Armoured = 24,
        GA_KO_Ninja = 25,
        GA_KO_CombatGun = 26,
        GA_KO_PredatorGun = 27,
        GA_KO_PredatorMinigun = 28,
        GA_KO_PredatorMedic = 29,
        GA_KO_PredatorSniper = 30,
        GA_KO_PredatorDMD = 31,
        GA_KO_PredatorMines = 32,
        GA_KO_PredatorJammer = 33,
        GA_KO_PredatorCamouflage = 34,
        GA_KO_PredatorRedhood = 35,
        GA_KO_PredatorDroneController = 36,
        GA_KO_PredatorSentryGun = 37,
        GA_KO_Sniper = 38,
        GA_KO_Medic = 39,
        GA_KO_Robot = 40,
        GA_KO_Dollotron = 41,
        GA_KO_Pyg = 42,
        GA_KO_Blackfire = 43,
        GA_KO_JokerBoxer = 44,
        GA_KO_RiddlerMech = 45,
        GA_KO_Lieutenant = 46,
        GA_Rescue = 47,
        GA_EvidenceTrailOver = 48,
        GA_Pickup = 49,
        GA_Pickup_Map = 50,
        GA_Pickup_Tape = 51,
        GA_Cipher_Found = 52,
        GA_Riddle_Solved = 53,
        GA_DropOnThug = 54,
        GA_ScareThug = 55,
        GA_SP_InitialDiscovery = 56,
        GA_SP_FurtherDiscovery = 57,
        GA_Stun_Batarang = 58,
        GA_Combo_XP_Multiplier = 59,
        GA_Combat_QuickStrike = 60,
        GA_Combat_HeavyStrike = 61,
        GA_Combat_ComboStrike = 62,
        GA_Combat_Counter = 63,
        GA_Combat_ComboCounter = 64,
        GA_Combat_ThrowCounter = 65,
        GA_Combat_Redirect = 66,
        GA_Combat_Evade = 67,
        GA_Combat_Stun = 68,
        GA_Combat_CriticalCounter = 69,
        GA_Combat_BladeCounter = 70,
        GA_Combat_SuperBladeCounter = 71,
        GA_Combat_ComboInc = 72,
        GA_Combat_ComboLost = 73,
        GA_Combat_FloorPickup = 74,
        GA_Combat_BeatdownStart = 75,
        GA_Combat_BeatdownDamage = 76,
        GA_Combat_PerfectFreeflow = 77,
        GA_Gadget_Grapple = 78,
        GA_Gadget_Grapple_Rescue = 79,
        GA_Gadget_Grapple_AnyTime = 80,
        GA_Gadget_Grapple_Failed = 81,
        GA_Gadget_Batarang180Flip = 82,
        GA_Gadget_Batarang = 83,
        GA_Gadget_ExplosiveGel = 84,
        GA_Gadget_BatClaw = 85,
        GA_Gadget_DualHandguns = 86,
        GA_Gadget_Resonator = 87,
        GA_Gadget_ControllableBatarang = 88,
        GA_Gadget_RoundTheBackarang = 89,
        GA_Gadget_MagneticBlast = 90,
        GA_Gadget_MagneticBlastRepel = 91,
        GA_Gadget_MagneticBlastGenerator = 92,
        GA_Gadget_FreezeSpray = 93,
        GA_Gadget_SmokeBomb = 94,
        GA_Gadget_JammerGadget = 95,
        GA_Gadget_LineLauncherTightRope = 96,
        GA_Gadget_LineLauncher_IfNotFired = 97,
        GA_Gadget_BatarangBrake = 98,
        GA_Gadget_RHD = 99,
        GA_Gadget_RHD_CodesDownloaded = 100,
        GA_Gadget_OmnitronAirship = 101,
        GA_Gadget_BatmobileRemote = 102,
        GA_Gadget_VoiceSynthesiserLock = 103,
        GA_Gadget_VoiceSynthesiserThug = 104,
        GA_Gadget_DisruptorSniper = 105,
        GA_Gadget_JackInTheBox = 106,
        GA_Gadget_RemoteHacking = 107,
        GA_Gadget_LineLauncher = 108,
        GA_Gadget_CombatBatClaw = 109,
        GA_Gadget_CombatBatarang = 110,
        GA_Gadget_Detonator = 111,
        GA_Gadget_Bullwhip = 112,
        GA_Gadget_CombatBullwhip = 113,
        GA_Gadget_BullwhipCombatDisarm = 114,
        GA_Gadget_Staff = 115,
        GA_Gadget_ShieldBash = 116,
        GA_Gadget_SticksAreaStun = 117,
        GA_Gadget_SticksRicochet = 118,
        GA_Gadget_WristDart = 119,
        GA_Gadget_StickyBomb = 120,
        GA_Gadget_ZipKick = 121,
        GA_Gadget_QuickBatarang = 122,
        GA_Gadget_QuickGel = 123,
        GA_Gadget_QuickDetonate = 124,
        GA_Gadget_QuickClaw = 125,
        GA_Gadget_QuickHandguns = 126,
        GA_Gadget_QuickFreeze = 127,
        GA_Gadget_QuickMagBlast = 128,
        GA_Gadget_DetonateGel = 129,
        GA_Gadget_QuickBullwhip = 130,
        GA_Gadget_DisruptorSniper_Equipped = 131,
        GA_Gadget_DisruptorSniper_TrackerTutorial = 132,
        GA_Gadget_DisruptorSniper_DroneDisruptorTutorial = 133,
        GA_Gadget_DoubleLineLauncher_Tutorial = 134,
        GA_EnygmaScreen_Tutorial = 135,
        GA_InvestigateMode = 136,
        GA_MapOpened = 137,
        GA_MostWanterWheel = 138,
        GA_Zoom = 139,
        GA_UnZoom = 140,
        GA_Agility_Climb = 141,
        GA_Agility_ClimbDown = 142,
        GA_Agility_Shimmy = 143,
        GA_Agility_DiveThroughWindow = 144,
        GA_Agility_WalkOnRailing = 145,
        GA_Agility_Swing = 146,
        GA_Agility_Slide = 147,
        GA_Agility_Jump = 148,
        GA_Agility_DropDown = 149,
        GA_Agility_Glide = 150,
        GA_Agility_DiveBoost = 151,
        GA_Agility_GrappleBoost = 152,
        GA_InvisiblePredator_Crouch = 153,
        GA_InvisiblePredator_CornerCover = 154,
        GA_InvisiblePredator_TunnelGrate = 155,
        GA_InvisiblePredator_HangMode = 156,
        GA_InvisiblePredator_JumpFromVantagePoint = 157,
        GA_InvisiblePredator_SwingToVantagePoint = 158,
        GA_InvisiblePredator_InstantSmokeBomb = 159,
        GA_InvisiblePredator_LineLauncherPerch = 160,
        GA_TakedownBeginTakedown = 161,
        GA_TakedownBeginFearTakedown = 162,
        GA_TakedownFearTakedownTimeout = 163,
        GA_TakedownFearTakedownEnded = 164,
        GA_Died = 165,
        GA_BM3PredChallenge_SilentTakedown = 166,
        GA_BM3PredChallenge_LedgeTakedown = 167,
        GA_BM3PredChallenge_WeakWallTakedown = 168,
        GA_BM3PredChallenge_WeakWallFearTakedown = 169,
        GA_BM3PredChallenge_MinigunEnvironmentKO = 170,
        GA_BM3PredChallenge_MedicLast = 171,
        GA_BM3PredChallenge_DroneControllerLast = 172,
        GA_BM3PredChallenge_VoiceSynthInvestigateExplosiveGelledWeakWall = 173,
        GA_BM3PredChallenge_TakedownWithTakedownPoint = 174,
        GA_BM3PredChallenge_4ThugFearTakedown = 175,
        GA_BM3PredChallenge_5ThugFearTakedown = 176,
        GA_BM3PredChallenge_2SeparateFearTakedowns = 177,
        GA_BM3PredChallenge_NoDamageDuringChallenge = 178,
        GA_BatmobileChallenge_SpottedByHeavyTank = 179,
        GA_Combat_CounterStart = 180,
        GA_SuperStun = 181,
        GA_StruckStunStickThug = 182,
        GA_ChallengeMedalGained = 183,
        GA_BatmobileWeapon_ChainGun = 184,
        GA_BatmobileWeapon_Winch = 185,
        GA_BatmobileWeapon_ForensicsScan = 186,
        GA_BatmobileWeapon_SonarPulse = 187,
        GA_BatmobileWeapon_SonarBlast = 188,
        GA_BatmobileWeapon_ScanCommanderTank = 189,
        GA_BatmobileWeapon_HeavyCannonHeavyTank = 190,
        GA_BatmobileWeapon_EMPBurst = 191,
        GA_BatmobileWeapon_MissileBarrageSingle = 192,
        GA_BatmobileWeapon_MissileBarrageMulti = 193,
        GA_BatmobileWeapon_DroneHacker = 194,
        GA_BatmobileWeapon_MineLauncher = 195,
        GA_BatmobileWeapon_DodgeThruster = 196,
        GA_BatmobileWeapon_HeavyCannon = 197,
        GA_BatmobileWeapon_BatTracker = 198,
        GA_Batmobile_CallBatmobile = 199,
        GA_Batmobile_GetInBatmobile = 200,
        GA_Batmobile_BattleModeMovement = 201,
        GA_Batmobile_BattleMode = 202,
        GA_Batmobile_Eject = 203,
        GA_Batmobile_E3_TankTrigger = 204,
        GA_Batmobile_KillTank = 205,
        GA_Batmobile_KillDrone = 206,
        GA_FlipGrateTakedown = 207,
        GA_RobinOrderedBatmanToDoATakedown = 208,
        GA_ReallyBeganAFearTakedownAndNotAKnockoutSmash = 209,
        GA_SilentCornerTakedownNew = 210,
        GA_BM3PredChallenge_2SeparateFearTakedownsWithin60Seconds = 211,
        GA_ExplosiveGelWeakWallTakedown = 212,
        GA_ExplosiveGelCeilingTakedown = 213,
        GA_IceSmashTakedown = 214,
        GA_ConcussionGrenadeHitThug = 215,
        GA_BatclawDisarm = 216,
        GA_FearTakedownFromGrate = 217,
        GA_SnapFlashKOedExactlyOneThug = 218,
        GA_SnapFlashKOedExactlyTwoThugs = 219,
        GA_SnapFlashKOedThreeOrMoreThugs = 220,
        GA_TakedownMultipleThugsWithTakedownPoint = 221,
        GA_ExplosiveGelWeakWallMultiTakedown = 222,
        GA_Kick2ThugsDuring1LineLaunch = 223,
        GA_SnapFlashPlaced = 224,
        GA_SnapFlashDetonated = 225,
        GA_RedHoodQuickShotThug = 226,
        GA_ExplosiveGelAffectedMultipleThugs = 227,
        GA_Kick3ThugsDuring1LineLaunch = 228,
        GA_LineLaunchKickThroughWindow = 229,
        GA_LedgeTakedownDLC = 230,
        GA_KnockoutSmash = 231,
        GA_FreezeGadgetThrownBM3DLC = 232,
        GA_Max = 233,
    }

    /// <summary>
    /// Struct: FContentBeacon
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FContentBeacon
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: DLC
        /// </summary>
        public unsafe BmSDK.FString DLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: TextPath
        /// </summary>
        public unsafe BmSDK.FString TextPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: Rotation
        /// </summary>
        public unsafe float Rotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// StructProperty: Range
        /// </summary>
        public unsafe System.Numerics.Vector4 Range
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// IntProperty: ParticleIndex
        /// </summary>
        public unsafe int ParticleIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// StrProperty: Package
        /// </summary>
        public unsafe BmSDK.FString Package
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// StrProperty: Action
        /// </summary>
        public unsafe BmSDK.FString Action
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// StrProperty: Prerequisite
        /// </summary>
        public unsafe BmSDK.FString Prerequisite
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }

        /// <summary>
        /// BoolProperty: Invisible
        /// </summary>
        public unsafe bool Invisible
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }; }
        }

        /// <summary>
        /// StrProperty: Title
        /// </summary>
        public unsafe BmSDK.FString Title
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }

        /// <summary>
        /// StrProperty: Subtitle
        /// </summary>
        public unsafe BmSDK.FString Subtitle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }

        /// <summary>
        /// StrProperty: Description
        /// </summary>
        public unsafe BmSDK.FString Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }

        /// <summary>
        /// StrProperty: Prompt
        /// </summary>
        public unsafe BmSDK.FString Prompt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }; }
        }

        /// <summary>
        /// StrProperty: Content
        /// </summary>
        public unsafe BmSDK.FString Content
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }; }
        }

        /// <summary>
        /// ByteProperty: State
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EContentBeaconState State
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EContentBeaconState>(Ptr + 216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }; }
        }

        /// <summary>
        /// ObjectProperty: Emitter
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Emitter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 220); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }; }
        }

        /// <summary>
        /// StructProperty: SpringFX
        /// </summary>
        public unsafe System.Numerics.Vector3 SpringFX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 228); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }; }
        }
    }

    /// <summary>
    /// Enum: EContentBeaconDisplayMode
    /// </summary>
    public enum EContentBeaconDisplayMode
    {
        CBDM_None = 0,
        CBDM_Mini = 1,
        CBDM_Full = 2,
        CBDM_MAX = 3,
    }

    /// <summary>
    /// Enum: EContentBeaconState
    /// </summary>
    public enum EContentBeaconState
    {
        CBS_Invisible = 0,
        CBS_Disabled = 1,
        CBS_Enabled = 2,
        CBS_Interactive = 3,
        CBS_MAX = 4,
    }

    /// <summary>
    /// Struct: FPositionBeaconData
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FPositionBeaconData
    {
        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Type
        /// </summary>
        public unsafe BmSDK.FString Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: InteractRadius
        /// </summary>
        public unsafe float InteractRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Radius
        /// </summary>
        public unsafe float Radius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FRiddlerPuzzle
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRiddlerPuzzle
    {
        /// <summary>
        /// ByteProperty: Id
        /// </summary>
        public unsafe byte Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Category
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.ERiddlerCategory Category
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ERiddlerCategory>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// StructProperty: Prize
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FRiddlerPuzzlePrize Prize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FRiddlerPuzzlePrize>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: Pieces
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRiddlerPuzzlePiece> Pieces
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRiddlerPuzzlePiece>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: ValidPieces
        /// </summary>
        public unsafe byte ValidPieces
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FRiddlerPuzzlePiece
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRiddlerPuzzlePiece
    {
        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.ERiddlerPiece Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ERiddlerPiece>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Id
        /// </summary>
        public unsafe byte Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: Collection
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.ERiddlerCollection Collection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ERiddlerCollection>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// ByteProperty: Count
        /// </summary>
        public unsafe byte Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3); }; }
        }
    }

    /// <summary>
    /// Struct: FRiddlerPuzzlePrize
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRiddlerPuzzlePrize
    {
        /// <summary>
        /// ByteProperty: Tape
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.ETapeCharacter Tape
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ETapeCharacter>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Prerequisite
        /// </summary>
        public unsafe BmSDK.FString Prerequisite
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: ERiddlerLocationName
    /// </summary>
    public enum ERiddlerLocationName
    {
        RiddlerLoc_CityX = 0,
        RiddlerLoc_CityY = 1,
        RiddlerLoc_CityZ = 2,
        RiddlerLoc_Film = 3,
        RiddlerLoc_Stagg = 4,
        RiddlerLoc_HideOut = 5,
        RiddlerLoc_MAX = 6,
    }

    /// <summary>
    /// Enum: ERiddlerState
    /// </summary>
    public enum ERiddlerState
    {
        RiddlerState_Unknown = 0,
        RiddlerState_Locked = 1,
        RiddlerState_New = 2,
        RiddlerState_Normal = 3,
        RiddlerState_Solved = 4,
        RiddlerState_Complete = 5,
        RiddlerState_MAX = 6,
    }

    /// <summary>
    /// Enum: ERiddlerPiece
    /// </summary>
    public enum ERiddlerPiece
    {
        RiddlerPiece_None = 0,
        RiddlerPiece_Trophy = 1,
        RiddlerPiece_Tape = 2,
        RiddlerPiece_Projected = 3,
        RiddlerPiece_Cameo = 4,
        RiddlerPiece_Breakable = 5,
        RiddlerPiece_Combat = 6,
        RiddlerPiece_Batmobile = 7,
        RiddlerPiece_Gadgets = 8,
        RiddlerPiece_Navigation = 9,
        RiddlerPiece_Predator = 10,
        RiddlerPiece_Bomb = 11,
        RiddlerPiece_MAX = 12,
    }

    /// <summary>
    /// Enum: ERiddlerCollection
    /// </summary>
    public enum ERiddlerCollection
    {
        RiddlerCollection_None = 0,
        RiddlerCollection_Pickups = 1,
        RiddlerCollection_Cameras = 2,
        RiddlerCollection_Insects = 3,
        RiddlerCollection_SpiderBots = 4,
        RiddlerCollection_Jacks = 5,
        RiddlerCollection_Scarecrows = 6,
        RiddlerCollection_Shields = 7,
        RiddlerCollection_Cameos = 8,
        RiddlerCollection_MAX = 9,
    }

    /// <summary>
    /// Enum: ERiddlerCategory
    /// </summary>
    public enum ERiddlerCategory
    {
        RiddlerCategory_Unknown = 0,
        RiddlerCategory_CityX = 1,
        RiddlerCategory_CityY = 2,
        RiddlerCategory_CityZ = 3,
        RiddlerCategory_Film = 4,
        RiddlerCategory_Stagg = 5,
        RiddlerCategory_Hideout = 6,
        RiddlerCategory_Player = 7,
        RiddlerCategory_MAX = 8,
    }

    /// <summary>
    /// Enum: ETapeCharacter
    /// </summary>
    public enum ETapeCharacter
    {
        Tape_None = 0,
        Tape_Simon_Stagg = 1,
        Tape_Harley_Quinn = 2,
        Tape_Arkham_Knight = 3,
        Tape_Riddler = 4,
        Tape_Scarecrow = 5,
        Tape_Penguin = 6,
        Tape_Professor_Pyg = 7,
        Tape_Joker = 8,
        Tape_Deacon_Blackfire = 9,
        Tape_MAX = 10,
    }

    /// <summary>
    /// Struct: FWBPlayRewardInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FWBPlayRewardInfo
    {
        /// <summary>
        /// StrProperty: Page
        /// </summary>
        public unsafe BmSDK.FString Page
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Item
        /// </summary>
        public unsafe BmSDK.FString Item
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: RewardFlagName
        /// </summary>
        public unsafe BmSDK.FString RewardFlagName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: PackageName
        /// </summary>
        public unsafe BmSDK.FString PackageName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StrProperty: RewardName
        /// </summary>
        public unsafe BmSDK.FString RewardName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FUpgradeItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FUpgradeItem
    {
        /// <summary>
        /// StrProperty: Page
        /// </summary>
        public unsafe BmSDK.FString Page
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Item
        /// </summary>
        public unsafe BmSDK.FString Item
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: X
        /// </summary>
        public unsafe int X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: Y
        /// </summary>
        public unsafe int Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: DX
        /// </summary>
        public unsafe int DX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: DY
        /// </summary>
        public unsafe int DY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: Scale
        /// </summary>
        public unsafe float Scale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StrProperty: Icon
        /// </summary>
        public unsafe BmSDK.FString Icon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StrProperty: Background
        /// </summary>
        public unsafe BmSDK.FString Background
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// StrProperty: Action
        /// </summary>
        public unsafe BmSDK.FString Action
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// StrProperty: Prerequisite
        /// </summary>
        public unsafe BmSDK.FString Prerequisite
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// IntProperty: Value
        /// </summary>
        public unsafe int Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }

        /// <summary>
        /// StrProperty: Header
        /// </summary>
        public unsafe BmSDK.FString Header
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// IntProperty: Hierarchy
        /// </summary>
        public unsafe int Hierarchy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }
    }

    /// <summary>
    /// Struct: FUpgradeHeader
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FUpgradeHeader
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: OX
        /// </summary>
        public unsafe float OX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: OY
        /// </summary>
        public unsafe float OY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: TX
        /// </summary>
        public unsafe float TX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: TY
        /// </summary>
        public unsafe float TY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: LeftJustify
        /// </summary>
        public unsafe bool LeftJustify
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Enum: UpgradeBoostAction
    /// </summary>
    public enum UpgradeBoostAction
    {
        UBA_Nothing = 0,
        UBA_PointsAwarded = 1,
        UBA_Boosted = 2,
        UBA_MAX = 3,
    }

    /// <summary>
    /// Struct: FShowcaseItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FShowcaseItem
    {
        /// <summary>
        /// StrProperty: Page
        /// </summary>
        public unsafe BmSDK.FString Page
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Item
        /// </summary>
        public unsafe BmSDK.FString Item
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: Levels
        /// </summary>
        public unsafe BmSDK.FString Levels
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: Icon
        /// </summary>
        public unsafe BmSDK.FString Icon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StrProperty: Prerequisite
        /// </summary>
        public unsafe BmSDK.FString Prerequisite
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// StrProperty: Camera
        /// </summary>
        public unsafe BmSDK.FString Camera
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// StrProperty: Skin
        /// </summary>
        public unsafe BmSDK.FString Skin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// StrProperty: Condition
        /// </summary>
        public unsafe BmSDK.FString Condition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// IntProperty: SortIndex
        /// </summary>
        public unsafe int SortIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }

        /// <summary>
        /// BoolProperty: Unlocked
        /// </summary>
        public unsafe bool Unlocked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }; }
        }

        /// <summary>
        /// BoolProperty: DLC
        /// </summary>
        public unsafe bool DLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }; }
        }

        /// <summary>
        /// BoolProperty: WBPlay
        /// </summary>
        public unsafe bool WBPlay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }; }
        }
    }

    /// <summary>
    /// Struct: FShowcaseCamera
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FShowcaseCamera
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: VantagePosition
        /// </summary>
        public unsafe System.Numerics.Vector3 VantagePosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: VantageLookAt
        /// </summary>
        public unsafe System.Numerics.Vector3 VantageLookAt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: VantageFOV
        /// </summary>
        public unsafe float VantageFOV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: InspectHeights
        /// </summary>
        public unsafe System.Numerics.Vector4 InspectHeights
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: InspectAngles
        /// </summary>
        public unsafe System.Numerics.Vector4 InspectAngles
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// StructProperty: InspectFOVs
        /// </summary>
        public unsafe System.Numerics.Vector3 InspectFOVs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: InspectDistance
        /// </summary>
        public unsafe float InspectDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }
    }

    /// <summary>
    /// Struct: FConceptItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FConceptItem
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Package
        /// </summary>
        public unsafe BmSDK.FString Package
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: Prerequisite
        /// </summary>
        public unsafe BmSDK.FString Prerequisite
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: DLC
        /// </summary>
        public unsafe bool DLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: Unlocked
        /// </summary>
        public unsafe bool Unlocked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FPredatorXPInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FPredatorXPInfo
    {
        /// <summary>
        /// BoolProperty: bNeverSeenBonus
        /// </summary>
        public unsafe bool bNeverSeenBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bNeverShotBonus
        /// </summary>
        public unsafe bool bNeverShotBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bPredatorAwarenessEnabled
        /// </summary>
        public unsafe bool bPredatorAwarenessEnabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: TakedownVariation
        /// </summary>
        public unsafe int TakedownVariation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: FearTakedowns
        /// </summary>
        public unsafe int FearTakedowns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: HealthRemaining
        /// </summary>
        public unsafe int HealthRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: TotalCombatants
        /// </summary>
        public unsafe int TotalCombatants
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: MaxCombatants
        /// </summary>
        public unsafe int MaxCombatants
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: NumThugs
        /// </summary>
        public unsafe int NumThugs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: NumMilitia
        /// </summary>
        public unsafe int NumMilitia
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: NumMiniguns
        /// </summary>
        public unsafe int NumMiniguns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: NumMedics
        /// </summary>
        public unsafe int NumMedics
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: NumCamouflage
        /// </summary>
        public unsafe int NumCamouflage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: NumSnipers
        /// </summary>
        public unsafe int NumSnipers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: NumRedhood
        /// </summary>
        public unsafe int NumRedhood
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: NumDMD
        /// </summary>
        public unsafe int NumDMD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// IntProperty: NumMines
        /// </summary>
        public unsafe int NumMines
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// IntProperty: NumDrones
        /// </summary>
        public unsafe int NumDrones
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// IntProperty: NumSentryGuns
        /// </summary>
        public unsafe int NumSentryGuns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// IntProperty: NumJammers
        /// </summary>
        public unsafe int NumJammers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
    }

    /// <summary>
    /// Struct: FCombatXPInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FCombatXPInfo
    {
        /// <summary>
        /// BoolProperty: bNoHitBonus
        /// </summary>
        public unsafe bool bNoHitBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bPerfectFreeflowBonus
        /// </summary>
        public unsafe bool bPerfectFreeflowBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumCombatants
        /// </summary>
        public unsafe int NumCombatants
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MaxCombo
        /// </summary>
        public unsafe int MaxCombo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: MaxVariation
        /// </summary>
        public unsafe int MaxVariation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: MaxGadgetVariation
        /// </summary>
        public unsafe int MaxGadgetVariation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: HealthRemaining
        /// </summary>
        public unsafe int HealthRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: PerfectFreeflow
        /// </summary>
        public unsafe int PerfectFreeflow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: NumThugs
        /// </summary>
        public unsafe int NumThugs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: NumMilitia
        /// </summary>
        public unsafe int NumMilitia
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: NumCombatExperts
        /// </summary>
        public unsafe int NumCombatExperts
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: NumBrutes
        /// </summary>
        public unsafe int NumBrutes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: NumMedics
        /// </summary>
        public unsafe int NumMedics
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: NumRobots
        /// </summary>
        public unsafe int NumRobots
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: NumDollotrons
        /// </summary>
        public unsafe int NumDollotrons
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// IntProperty: NumPyg
        /// </summary>
        public unsafe int NumPyg
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// IntProperty: NumBlackfire
        /// </summary>
        public unsafe int NumBlackfire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// IntProperty: NumJokerBoxer
        /// </summary>
        public unsafe int NumJokerBoxer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// IntProperty: NumRiddlerMech
        /// </summary>
        public unsafe int NumRiddlerMech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// IntProperty: NumBats
        /// </summary>
        public unsafe int NumBats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// IntProperty: NumKnives
        /// </summary>
        public unsafe int NumKnives
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// IntProperty: NumShields
        /// </summary>
        public unsafe int NumShields
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// IntProperty: NumStunSticks
        /// </summary>
        public unsafe int NumStunSticks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// IntProperty: NumGuns
        /// </summary>
        public unsafe int NumGuns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// IntProperty: NumCrates
        /// </summary>
        public unsafe int NumCrates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// IntProperty: TotalCombatantIncludingNoXP
        /// </summary>
        public unsafe int TotalCombatantIncludingNoXP
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
    }

    /// <summary>
    /// Enum: EHudWeaponType
    /// </summary>
    public enum EHudWeaponType
    {
        HWT_None = 0,
        HWT_Knives = 1,
        HWT_Rifle = 2,
        HWT_Pipe = 3,
        HWT_StunStick = 4,
        HWT_Shotgun = 5,
        HWT_Bat = 6,
        HWT_Bottle = 7,
        HWT_Machete = 8,
        HWT_Sword = 9,
        HWT_Shield = 10,
        HWT_Sledgehammer = 11,
        HWT_Truncheon = 12,
        HWT_SniperRifle = 13,
        HWT_RPGLauncher = 14,
        HWT_JammedRifle = 15,
        HWT_JammedShotgun = 16,
        HWT_JammedSniperRifle = 17,
        HWT_FireflyFlamethrower = 18,
        HWT_Minigun = 19,
        HWT_JammedMinigun = 20,
        HWT_BruteMilitiaBlade = 21,
        HWT_BruteMilitiaGloves = 22,
        HWT_BruteMilitiaShield = 23,
        HWT_BruteThugBlade = 24,
        HWT_BruteThugGloves = 25,
        HWT_HarleyRifle = 26,
        HWT_Robot = 27,
        HWT_ExplosiveVest = 28,
        HWT_MAX = 29,
    }

    /// <summary>
    /// Enum: AAITakedownType
    /// </summary>
    public enum AAITakedownType
    {
        eAAITakeDownType_Grate = 0,
        eAAITakeDownType_Silent = 1,
        eAAITakeDownType_Ledge = 2,
        eAAITakeDownType_VeryWeakWall = 3,
        eAAITakeDownType_WallExplode = 4,
        eAAITakeDownType_ThroughGlass = 5,
        eAAITakeDownType_Glide = 6,
        eAAITakeDownType_Drop = 7,
        eAAITakeDownType_Inverted = 8,
        eAAITakeDownType_Tunnel = 9,
        eAAITakeDownType_DroneShock = 10,
        eAAITakeDownType_ReverseLedge = 11,
        eAAITakeDownType_MAX = 12,
    }

    /// <summary>
    /// Enum: RPMAPCSpawnResultWheel
    /// </summary>
    public enum RPMAPCSpawnResultWheel
    {
        RPMAPC_RESULT_APCOnIslandX = 0,
        RPMAPC_RESULT_APCOnIslandY = 1,
        RPMAPC_RESULT_APCOnIslandZ = 2,
        RPMAPC_RESULT_Failed = 3,
        RPMAPC_RESULT_MAX = 4,
    }

    /// <summary>
    /// Enum: RPMAPCSpawnStatusWheel
    /// </summary>
    public enum RPMAPCSpawnStatusWheel
    {
        RPMAPC_NoAPCNotUnlocked = 0,
        RPMAPC_NoAPCTimeLimitKilled = 1,
        RPMAPC_NoAPCTimeLimitLost = 2,
        RPMAPC_NoAPCNoSpaceDrones = 3,
        RPMAPC_APCCanSpawn = 4,
        RPMAPC_NoAPCsRemaining = 5,
        RPMAPC_MAX = 6,
    }

    /// <summary>
    /// Enum: ELive_LiveError
    /// </summary>
    public enum ELive_LiveError
    {
        EL_None = 0,
        EL_LoginLost = 1,
        EL_LoginChanged = 2,
        EL_NotConnected = 3,
        EL_Connected = 4,
        EL_ConnectionDropped = 5,
        EL_NoNetworkConnection = 6,
        EL_ServiceUnavailable = 7,
        EL_UpdateRequired = 8,
        EL_ServersTooBusy = 9,
        EL_DuplicateLoginDetected = 10,
        EL_InvalidUser = 11,
        EL_PS3NotConnected = 12,
        EL_PS3NotLoggedIn = 13,
        EL_DLCInvalidated = 14,
        EL_MAX = 15,
    }

    /// <summary>
    /// Enum: EGS_Reason
    /// </summary>
    public enum EGS_Reason
    {
        EGS_None = 0,
        EGS_StoryExit = 1,
        EGS_StoryComplete = 2,
        EGS_Challenge_Lost = 3,
        EGS_Challenge_Won = 4,
        EGS_MAX = 5,
    }

    /// <summary>
    /// Enum: ECheatCode
    /// </summary>
    public enum ECheatCode
    {
        ECheatCode_Menu = 0,
        ECheatCode_GodMode = 1,
        ECheatCode_BigHeadMode = 2,
        ECheatCode_StretchHeadMode = 3,
        ECheatCode_MAX = 4,
    }

    /// <summary>
    /// Enum: EDistrict
    /// </summary>
    public enum EDistrict
    {
        EDISTRICT_None = 0,
        EDISTRICT_CityX = 1,
        EDISTRICT_CityY = 2,
        EDISTRICT_CityZ = 3,
        EDISTRICT_MAX = 4,
    }

    /// <summary>
    /// Enum: EChallengeRankMode
    /// </summary>
    public enum EChallengeRankMode
    {
        ECRM_HighScore = 0,
        ECRM_LowScore = 1,
        ECRM_LongestTime = 2,
        ECRM_ShortestTime = 3,
        ECRM_MAX = 4,
    }

    /// <summary>
    /// Enum: EChallengeBeaconStyle
    /// </summary>
    public enum EChallengeBeaconStyle
    {
        ECBeaconStyle_Default = 0,
        ECBeaconStyle_Batman = 1,
        ECBeaconStyle_BatSymbol = 2,
        ECBeaconStyle_City = 3,
        ECBeaconStyle_Weapon = 4,
        ECBeaconStyle_Wheel = 5,
        ECBeaconStyle_Combat = 6,
        ECBeaconStyle_Hybrid = 7,
        ECBeaconStyle_MAX = 8,
    }

    /// <summary>
    /// Enum: EChallengeFrontendState
    /// </summary>
    public enum EChallengeFrontendState
    {
        ECFrontendState_Default = 0,
        ECFrontendState_Revealed = 1,
        ECFrontendState_Unlocked = 2,
        ECFrontendState_FrontendOnly = 3,
        ECFrontendState_FrontendOnlyLocked = 4,
        ECFrontendState_MAX = 5,
    }

    /// <summary>
    /// Enum: EChallengeFrontendGroup
    /// </summary>
    public enum EChallengeFrontendGroup
    {
        ECFrontendGroup_Tutorial = 0,
        ECFrontendGroup_Combat = 1,
        ECFrontendGroup_Predator = 2,
        ECFrontendGroup_Navigation = 3,
        ECFrontendGroup_BatmobileRace = 4,
        ECFrontendGroup_BatmobileCombat = 5,
        ECFrontendGroup_BatmobileHybrid = 6,
        ECFrontendGroup_Narrative = 7,
        ECFrontendGroup_Scarecrow = 8,
        ECFrontendGroup_PlatformExclusive = 9,
        ECFrontendGroup_MAX = 10,
    }

    /// <summary>
    /// Enum: EInstallChunk
    /// </summary>
    public enum EInstallChunk
    {
        InstallChunk_Base = 0,
        InstallChunk_SelectNewGame = 1,
        InstallChunk_AfterDiner = 2,
        InstallChunk_BeforeLockup = 3,
        InstallChunk_BeforeAce = 4,
        InstallChunk_AfterJokerShootsBatman = 5,
        InstallChunk_AtPenguinCacheC1 = 6,
        InstallChunk_AtStaggScarecrow = 7,
        InstallChunk_MAX = 8,
    }

    /// <summary>
    /// Enum: EGameModes
    /// </summary>
    public enum EGameModes
    {
        EGM_Frontend = 0,
        EGM_Story = 1,
        EGM_Challenge = 2,
        EGM_MAX = 3,
    }

    /// <summary>
    /// Enum: ELeaderboardColumns
    /// </summary>
    public enum ELeaderboardColumns
    {
        ELBC_RatingScore = 0,
        ELBC_Score = 1,
        ELBC_Medal = 2,
        ELBC_RivalPoints = 3,
        ELBC_MAX = 4,
    }

    /// <summary>
    /// Enum: EEvadeVehicleType
    /// </summary>
    public enum EEvadeVehicleType
    {
        EEVADEVEHICLE_None = 0,
        EEVADEVEHICLE_Stumble = 1,
        EEVADEVEHICLE_Dive = 2,
        EEVADEVEHICLE_Stun = 3,
        EEVADEVEHICLE_MAX = 4,
    }

    /// <summary>
    /// Enum: StreamedCombatWeaponTypes
    /// </summary>
    public enum StreamedCombatWeaponTypes
    {
        COMBATWEAPON_None = 0,
        COMBATWEAPON_Rifle = 1,
        COMBATWEAPON_Knife = 2,
        COMBATWEAPON_Bottle = 3,
        COMBATWEAPON_Pipe = 4,
        COMBATWEAPON_Bat = 5,
        COMBATWEAPON_Shield = 6,
        COMBATWEAPON_StunStick = 7,
        COMBATWEAPON_MAX = 8,
    }

    /// <summary>
    /// Enum: StreamedPredWeaponTypes
    /// </summary>
    public enum StreamedPredWeaponTypes
    {
        PREDWEAPON_Rifle = 0,
        PREDWEAPON_Shotgun = 1,
        PREDWEAPON_Sniper = 2,
        PREDWEAPON_None = 3,
        PREDWEAPON_MAX = 4,
    }

    /// <summary>
    /// Enum: VocalPriority
    /// </summary>
    public enum VocalPriority
    {
        EVP_Default = 0,
        EVP_Low = 1,
        EVP_Medium = 2,
        EVP_High = 3,
        EVP_Highest = 4,
        EVP_DuckAllOther = 5,
        EVP_MAX = 6,
    }

    /// <summary>
    /// Enum: VocalType
    /// </summary>
    public enum VocalType
    {
        EVT_Emote = 0,
        EVT_Bark = 1,
        EVT_Speech = 2,
        EVT_MAX = 3,
    }

    /// <summary>
    /// Struct: FHelicopterPointOfInterest
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FHelicopterPointOfInterest
    {
        /// <summary>
        /// ObjectProperty: TheActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor TheActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: ActorPoiType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes ActorPoiType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: HelicopterPointOfInterestTypes
    /// </summary>
    public enum HelicopterPointOfInterestTypes
    {
        HPOI_None = 0,
        HPOI_Riot = 1,
        HPOI_DroneTank = 2,
        HPOI_DroneAerial = 3,
        HPOI_DroneGroup = 4,
        HPOI_DroneHeavyTank = 5,
        HPOI_MostWantedApc = 6,
        HPOI_MostWantedBank = 7,
        HPOI_MostWantedCommandBeacon = 8,
        HPOI_MostWantedCheckpoint = 9,
        HPOI_MostWantedAzraelRooftop = 10,
        HPOI_MostWantedFireflyBuilding = 11,
        HPOI_Batman = 12,
        HPOI_MostWantedPyg = 13,
        HPOI_MostWantedFirecrew = 14,
        HPOI_MAX = 15,
    }

    /// <summary>
    /// Struct: FLevelTransitionOffset
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FLevelTransitionOffset
    {
        /// <summary>
        /// NameProperty: Level
        /// </summary>
        public unsafe BmSDK.FName Level
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: LevelAsString
        /// </summary>
        public unsafe BmSDK.FString LevelAsString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: TargetPMap
        /// </summary>
        public unsafe BmSDK.FString TargetPMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: Offset
        /// </summary>
        public unsafe System.Numerics.Vector3 Offset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FLevelStartDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FLevelStartDefinition
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: LevelNames
        /// </summary>
        public unsafe BmSDK.FString LevelNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FResolutionOption
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FResolutionOption
    {
        /// <summary>
        /// IntProperty: ResX
        /// </summary>
        public unsafe int ResX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ResY
        /// </summary>
        public unsafe int ResY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FKeyMap
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FKeyMap
    {
        /// <summary>
        /// StrProperty: Ability
        /// </summary>
        public unsafe BmSDK.FString Ability
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PrimaryKeyName
        /// </summary>
        public unsafe BmSDK.FString PrimaryKeyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: SecondaryKeyName
        /// </summary>
        public unsafe BmSDK.FString SecondaryKeyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: Command
        /// </summary>
        public unsafe BmSDK.FString Command
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StrProperty: Icon
        /// </summary>
        public unsafe BmSDK.FString Icon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// IntProperty: bPrimaryCtrl
        /// </summary>
        public unsafe int bPrimaryCtrl
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// IntProperty: bPrimaryShift
        /// </summary>
        public unsafe int bPrimaryShift
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// IntProperty: bPrimaryAlt
        /// </summary>
        public unsafe int bPrimaryAlt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// IntProperty: bSecondaryCtrl
        /// </summary>
        public unsafe int bSecondaryCtrl
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// IntProperty: bSecondaryShift
        /// </summary>
        public unsafe int bSecondaryShift
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// IntProperty: bSecondaryAlt
        /// </summary>
        public unsafe int bSecondaryAlt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: GameplayEventsWriter
    /// </summary>
    public unsafe BmSDK.BmGame.RGameplayEventsHydra GameplayEventsWriter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameplayEventsHydra>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// ObjectProperty: LightningEventListener
    /// </summary>
    public unsafe BmSDK.BmGame.RLightningActor LightningEventListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLightningActor>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// ObjectProperty: MapControllerEventListener
    /// </summary>
    public unsafe BmSDK.BmGame.RMapController MapControllerEventListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMapController>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// ObjectProperty: ContentBeaconPanel
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI_ContentBeaconPanel ContentBeaconPanel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI_ContentBeaconPanel>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// ObjectProperty: ContentBeaconMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ContentBeaconMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// ObjectProperty: PopulationManager
    /// </summary>
    public unsafe BmSDK.BmGame.RPopulationManager PopulationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPopulationManager>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// ObjectProperty: CrowdManager
    /// </summary>
    public unsafe BmSDK.BmGame.RCrowdManager CrowdManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCrowdManager>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// ObjectProperty: CombatBarkCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBarkCoordinator CombatBarkCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBarkCoordinator>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// ObjectProperty: AkBeacon
    /// </summary>
    public unsafe BmSDK.BmGame.AkAudioBeacon AkBeacon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AkAudioBeacon>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// ObjectProperty: GunShotManager
    /// </summary>
    public unsafe BmSDK.BmGame.RGunShotManager GunShotManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGunShotManager>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// ObjectProperty: VehicleCombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleCombatManager VehicleCombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleCombatManager>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// ObjectProperty: DroneCommanderTannoy
    /// </summary>
    public unsafe BmSDK.BmGame.RDroneCommanderTannoy DroneCommanderTannoy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDroneCommanderTannoy>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// ObjectProperty: CachedPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerControllerCombat CachedPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerCombat>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// ObjectProperty: DeadBatmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// ObjectProperty: HighestPriorityNonCustomObjectivePointer
    /// </summary>
    public unsafe BmSDK.BmGame.RObjectiveMarker HighestPriorityNonCustomObjectivePointer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RObjectiveMarker>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// ObjectProperty: ActiveTakeoverVideoScreensAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_TakeoverVideoScreens ActiveTakeoverVideoScreensAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_TakeoverVideoScreens>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// ObjectProperty: temporaryLightningSwappedActor
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerSwappableBase temporaryLightningSwappedActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerSwappableBase>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// ObjectProperty: VehicleRoundRobin
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle VehicleRoundRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// ObjectProperty: DeadVehicleRoundRobin
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadVehicleRoundRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunDefaultAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunDefaultAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunUpAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunUpAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// ObjectProperty: ManDownPeekAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ManDownPeekAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// ObjectProperty: GuardPointAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager GuardPointAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ObjectProperty: LastStandAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager LastStandAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: ReloadAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ReloadAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// ObjectProperty: TutThugAimingAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager TutThugAimingAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// ObjectProperty: PerimOutAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PerimOutAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// ObjectProperty: PlayerSwitchPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn PlayerSwitchPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// ObjectProperty: CurrentJoker
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn CurrentJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ObjectProperty: JokerFrequencyController
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerHallucinationFrequencyController JokerFrequencyController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerHallucinationFrequencyController>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: CurrentManbat
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn CurrentManbat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ObjectProperty: ManbatController
    /// </summary>
    public unsafe BmSDK.BmGame.RManBatAppearanceController ManbatController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RManBatAppearanceController>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: DoubleTeamAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_ToggleRobinLieutenantAssist DoubleTeamAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_ToggleRobinLieutenantAssist>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ObjectProperty: VideoScreenTakeoverMaterialToInstance
    /// </summary>
    public unsafe BmSDK.Engine.Material VideoScreenTakeoverMaterialToInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// ObjectProperty: VideoScreenOverrideMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant VideoScreenOverrideMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ObjectProperty: TriggerVolumeList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass TriggerVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ComponentProperty: CurrentRoomAIState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState CurrentRoomAIState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// StrProperty: FadeDownBy
    /// </summary>
    public unsafe BmSDK.FString FadeDownBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// StrProperty: AudioFadeDownBy
    /// </summary>
    public unsafe BmSDK.FString AudioFadeDownBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// ArrayProperty: DefaultBatmanKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultBatmanKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// ArrayProperty: DefaultPursuitKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultPursuitKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// ArrayProperty: DefaultBattleKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultBattleKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// ArrayProperty: DebugLevelStarts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelStartDefinition> DebugLevelStarts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelStartDefinition>>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerInterrogationTracks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerInterrogationTracks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// StrProperty: RiddlerInterrogationTrackIntro
    /// </summary>
    public unsafe BmSDK.FString RiddlerInterrogationTrackIntro
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// StrProperty: RiddlerInterrogationTrackDemo
    /// </summary>
    public unsafe BmSDK.FString RiddlerInterrogationTrackDemo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerInterrogationTrackFightBack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerInterrogationTrackFightBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// ArrayProperty: NumRiddlersX
    /// </summary>
    public unsafe BmSDK.TArray<int> NumRiddlersX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// ArrayProperty: NumRiddlersY
    /// </summary>
    public unsafe BmSDK.TArray<int> NumRiddlersY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// ArrayProperty: NumRiddlersZ
    /// </summary>
    public unsafe BmSDK.TArray<int> NumRiddlersZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitionOffsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelTransitionOffset> LevelTransitionOffsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelTransitionOffset>>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// ArrayProperty: HelicopterPointsOfInterest
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FHelicopterPointOfInterest> HelicopterPointsOfInterest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FHelicopterPointOfInterest>>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// ArrayProperty: checkPointMines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCheckPointMineBase> checkPointMines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCheckPointMineBase>>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ArrayProperty: commandBeacons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCommandBeaconBase> commandBeacons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCommandBeaconBase>>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ArrayProperty: AllThugScarableCrows
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCrowsBase> AllThugScarableCrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCrowsBase>>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// IntProperty: CrowTimeSliceIndex
    /// </summary>
    public unsafe int CrowTimeSliceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ArrayProperty: AllPathElevationCheckingActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIAction_BaseMove> AllPathElevationCheckingActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIAction_BaseMove>>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }

    /// <summary>
    /// IntProperty: PathElevationCheck_TimeSliceIndex
    /// </summary>
    public unsafe int PathElevationCheck_TimeSliceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// ArrayProperty: UnregisteredLockInVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLockinVolume> UnregisteredLockInVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLockinVolume>>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ArrayProperty: UnregisteredPredTannoyList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerTannoy> UnregisteredPredTannoyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerTannoy>>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ArrayProperty: UnregisteredFractureWallList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDestructibleProp_FractureWall> UnregisteredFractureWallList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDestructibleProp_FractureWall>>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// StrProperty: acquiredBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString acquiredBMBLUpgradeFlagNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }
    /// <summary>
    /// StrProperty: acquiredBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString acquiredBMBLUpgradeFlagNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }
    /// <summary>
    /// StrProperty: acquiredBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString acquiredBMBLUpgradeFlagNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }
    /// <summary>
    /// StrProperty: acquiredBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString acquiredBMBLUpgradeFlagNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// StrProperty: unavailableBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString unavailableBMBLUpgradeFlagNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }
    /// <summary>
    /// StrProperty: unavailableBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString unavailableBMBLUpgradeFlagNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }
    /// <summary>
    /// StrProperty: unavailableBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString unavailableBMBLUpgradeFlagNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }
    /// <summary>
    /// StrProperty: unavailableBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString unavailableBMBLUpgradeFlagNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// StrProperty: nextBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString nextBMBLUpgradeFlagNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }
    /// <summary>
    /// StrProperty: nextBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString nextBMBLUpgradeFlagNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }
    /// <summary>
    /// StrProperty: nextBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString nextBMBLUpgradeFlagNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }
    /// <summary>
    /// StrProperty: nextBMBLUpgradeFlagNames
    /// </summary>
    public unsafe BmSDK.FString nextBMBLUpgradeFlagNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// BoolProperty: bDbgJokerBillboards
    /// </summary>
    public unsafe bool bDbgJokerBillboards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bJokerBillboardQAMode
    /// </summary>
    public unsafe bool bJokerBillboardQAMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bFireflyActive
    /// </summary>
    public unsafe bool bFireflyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ShowcaseItemsSorted
    /// </summary>
    public unsafe bool ShowcaseItemsSorted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: m_bUpgradeHierarchyBuilt
    /// </summary>
    public unsafe bool m_bUpgradeHierarchyBuilt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSavedSecretsLeftToReveal
    /// </summary>
    public unsafe bool bSavedSecretsLeftToReveal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: PositionBeaconBestInteractable
    /// </summary>
    public unsafe bool PositionBeaconBestInteractable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ContentBeaconRequiresExitArea
    /// </summary>
    public unsafe bool ContentBeaconRequiresExitArea
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ContentBeaconHydraQueryInitiated
    /// </summary>
    public unsafe bool ContentBeaconHydraQueryInitiated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bShowingBatmobileOnHud
    /// </summary>
    public unsafe bool bShowingBatmobileOnHud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bPlayerControllingBatmobile
    /// </summary>
    public unsafe bool bPlayerControllingBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bPlayerControllingBatmobileAndMovingFast
    /// </summary>
    public unsafe bool bPlayerControllingBatmobileAndMovingFast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bHead2Head
    /// </summary>
    public unsafe bool bHead2Head
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bStoryDLC
    /// </summary>
    public unsafe bool bStoryDLC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSavingStartPoints
    /// </summary>
    public unsafe bool bSavingStartPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bDemoBuild
    /// </summary>
    public unsafe bool bDemoBuild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bDisableDebug
    /// </summary>
    public unsafe bool bDisableDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bShowChaseStartPos
    /// </summary>
    public unsafe bool bShowChaseStartPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bLevelDisabledLightningStrikes
    /// </summary>
    public unsafe bool bLevelDisabledLightningStrikes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ObjectiveSystemSuppressed
    /// </summary>
    public unsafe bool ObjectiveSystemSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bNoGadgets
    /// </summary>
    public unsafe bool bNoGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSilentTakeDownOnly
    /// </summary>
    public unsafe bool bSilentTakeDownOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bNoGrapple
    /// </summary>
    public unsafe bool bNoGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bNoInvestigateMode
    /// </summary>
    public unsafe bool bNoInvestigateMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bUseLowLineLauncherHeight
    /// </summary>
    public unsafe bool bUseLowLineLauncherHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: LevelLoadedAndReady
    /// </summary>
    public unsafe bool LevelLoadedAndReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSuspendAllDeadGameOverOLD
    /// </summary>
    public unsafe bool bSuspendAllDeadGameOverOLD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bDoCombatGrapnelToVpointArriveCheck
    /// </summary>
    public unsafe bool bDoCombatGrapnelToVpointArriveCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ParticlePushBMAffectBaseVel
    /// </summary>
    public unsafe bool ParticlePushBMAffectBaseVel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ParticlePushBMBLAffectBaseVel
    /// </summary>
    public unsafe bool ParticlePushBMBLAffectBaseVel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: ChallengeMapListSorted
    /// </summary>
    public unsafe bool ChallengeMapListSorted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bSplitscreenCaptureMode
    /// </summary>
    public unsafe bool bSplitscreenCaptureMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2784); }
    }

    /// <summary>
    /// BoolProperty: bPreventPauseOnControllerRemoval
    /// </summary>
    public unsafe bool bPreventPauseOnControllerRemoval
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: SavedOWDTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedOWDTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: SavedMuseumTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedMuseumTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: SavedUnderTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedUnderTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bDualPlayPredatorActive
    /// </summary>
    public unsafe bool bDualPlayPredatorActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bSuppressDualPlayMoves
    /// </summary>
    public unsafe bool bSuppressDualPlayMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bDualPlayerSwitchingDisabled
    /// </summary>
    public unsafe bool bDualPlayerSwitchingDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bDualPlayerSwitchingDisabledBySeq
    /// </summary>
    public unsafe bool bDualPlayerSwitchingDisabledBySeq
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bManbatCurrentlyActive
    /// </summary>
    public unsafe bool bManbatCurrentlyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bHasWarnedAboutInvalidRiotLinkPoints
    /// </summary>
    public unsafe bool bHasWarnedAboutInvalidRiotLinkPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bInsideRadioModeConversationStartSpeechCall
    /// </summary>
    public unsafe bool bInsideRadioModeConversationStartSpeechCall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bHasSetFrontEndChallenge
    /// </summary>
    public unsafe bool bHasSetFrontEndChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bIsFrontEndChallenge
    /// </summary>
    public unsafe bool bIsFrontEndChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: StoreContentQueryInitiated
    /// </summary>
    public unsafe bool StoreContentQueryInitiated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: StoreContentQueryCompleted
    /// </summary>
    public unsafe bool StoreContentQueryCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: StoreContentQuerySuccessful
    /// </summary>
    public unsafe bool StoreContentQuerySuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: StoreContentQueryDebug
    /// </summary>
    public unsafe bool StoreContentQueryDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bMinMemChecked
    /// </summary>
    public unsafe bool bMinMemChecked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bMinVideoDriverChecked
    /// </summary>
    public unsafe bool bMinVideoDriverChecked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bExternallyModifiedInisChecked
    /// </summary>
    public unsafe bool bExternallyModifiedInisChecked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// BoolProperty: bCachedFailsafeSeenSeqEvents
    /// </summary>
    public unsafe bool bCachedFailsafeSeenSeqEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2788); }
    }

    /// <summary>
    /// ArrayProperty: lootPointsWaitingForBeginPlay
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootPointBase> lootPointsWaitingForBeginPlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootPointBase>>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// ArrayProperty: gratesWaitingForBeginPlay
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> gratesWaitingForBeginPlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(Ptr + 2808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2808); }
    }

    /// <summary>
    /// ArrayProperty: sentryGunsWaitingForBeginPlay
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryGunBase> sentryGunsWaitingForBeginPlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryGunBase>>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// ArrayProperty: ConceptItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FConceptItem> ConceptItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FConceptItem>>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// ArrayProperty: ShowcaseCameras
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FShowcaseCamera> ShowcaseCameras
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FShowcaseCamera>>(Ptr + 2856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }
    }

    /// <summary>
    /// ArrayProperty: ShowcaseItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FShowcaseItem> ShowcaseItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FShowcaseItem>>(Ptr + 2872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2872); }
    }

    /// <summary>
    /// IntProperty: ShowcaseItemsLength
    /// </summary>
    public unsafe int ShowcaseItemsLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2888); }
    }

    /// <summary>
    /// ArrayProperty: UpgradeHeaders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FUpgradeHeader> UpgradeHeaders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FUpgradeHeader>>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// ArrayProperty: UpgradeItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FUpgradeItem> UpgradeItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FUpgradeItem>>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// ArrayProperty: UpgradeBoosters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> UpgradeBoosters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// ArrayProperty: BAMRewards
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo> BAMRewards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo>>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// ArrayProperty: BAKRewards
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo> BAKRewards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FWBPlayRewardInfo>>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerPuzzles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRiddlerPuzzle> RiddlerPuzzles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRiddlerPuzzle>>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// IntProperty: RiddlerPuzzleLastModified
    /// </summary>
    public unsafe int RiddlerPuzzleLastModified
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }

    /// <summary>
    /// IntProperty: RiddlerPuzzlePieceLastModified
    /// </summary>
    public unsafe int RiddlerPuzzlePieceLastModified
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }
    }

    /// <summary>
    /// IntProperty: RiddlerPuzzleCachedTotal
    /// </summary>
    public unsafe int RiddlerPuzzleCachedTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2996); }
    }

    /// <summary>
    /// IntProperty: SavedPickupReveals
    /// </summary>
    public unsafe int SavedPickupReveals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }

    /// <summary>
    /// ArrayProperty: PositionBeacons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FPositionBeaconData> PositionBeacons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FPositionBeaconData>>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// StructProperty: PositionBeaconCachedPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 PositionBeaconCachedPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// StructProperty: PositionBeaconCachedDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 PositionBeaconCachedDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3032); }
    }

    /// <summary>
    /// StrProperty: PositionBeaconBestType
    /// </summary>
    public unsafe BmSDK.FString PositionBeaconBestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// StructProperty: PositionBeaconBestPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 PositionBeaconBestPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// IntProperty: PositionBeaconBestId
    /// </summary>
    public unsafe int PositionBeaconBestId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }

    /// <summary>
    /// ArrayProperty: ContentBeacons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FContentBeacon> ContentBeacons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FContentBeacon>>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// ByteProperty: ContentBeaconCurrentDisplayMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode ContentBeaconCurrentDisplayMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode>(Ptr + 3092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3092); }
    }

    /// <summary>
    /// ByteProperty: GameMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameModes GameMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameModes>(Ptr + 3093); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3093); }
    }

    /// <summary>
    /// ByteProperty: StasisLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStasisLevel StasisLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStasisLevel>(Ptr + 3094); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3094); }
    }

    /// <summary>
    /// IntProperty: ContentBeaconCurrentIndex
    /// </summary>
    public unsafe int ContentBeaconCurrentIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3096); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Main
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Main
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Dup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Dup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// ArrayProperty: AAITakedownMapping
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FGameActionToAAITakedownMapping> AAITakedownMapping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FGameActionToAAITakedownMapping>>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }

    /// <summary>
    /// FloatProperty: sideStoryCooldownTimers
    /// </summary>
    public unsafe float sideStoryCooldownTimers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }
    /// <summary>
    /// FloatProperty: sideStoryCooldownTimers
    /// </summary>
    public unsafe float sideStoryCooldownTimers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }
    }
    /// <summary>
    /// FloatProperty: sideStoryCooldownTimers
    /// </summary>
    public unsafe float sideStoryCooldownTimers_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// FloatProperty: LastUturnBarkTime
    /// </summary>
    public unsafe float LastUturnBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// StrProperty: ChallengeRequiredFlags
    /// </summary>
    public unsafe BmSDK.FString ChallengeRequiredFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// StrProperty: ChallengeRequiredChapters
    /// </summary>
    public unsafe BmSDK.FString ChallengeRequiredChapters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }

    /// <summary>
    /// FloatProperty: SessionTimePlayed
    /// </summary>
    public unsafe float SessionTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// FloatProperty: FootstepNoiseDist
    /// </summary>
    public unsafe float FootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// FloatProperty: WalkFootstepNoiseDist
    /// </summary>
    public unsafe float WalkFootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// FloatProperty: TakedownNoiseDist
    /// </summary>
    public unsafe float TakedownNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// FloatProperty: ChaseCheatTime
    /// </summary>
    public unsafe float ChaseCheatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }

    /// <summary>
    /// FloatProperty: RBSmashSpeedAlertThreshold
    /// </summary>
    public unsafe float RBSmashSpeedAlertThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3220); }
    }

    /// <summary>
    /// FloatProperty: GunStartleTimer
    /// </summary>
    public unsafe float GunStartleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3224); }
    }

    /// <summary>
    /// StructProperty: CurrentWindState
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FRWindState CurrentWindState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FRWindState>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }

    /// <summary>
    /// StructProperty: CurrentWindConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FRWindConfig CurrentWindConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FRWindConfig>(Ptr + 3296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }
    }

    /// <summary>
    /// FloatProperty: CurrentRainIntensity
    /// </summary>
    public unsafe float CurrentRainIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }

    /// <summary>
    /// ArrayProperty: ObjectiveMarkers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker> ObjectiveMarkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker>>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// IntProperty: VisibleObjectiveMarker
    /// </summary>
    public unsafe int VisibleObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// IntProperty: HighestPriorityNonCustomObjectiveMarker
    /// </summary>
    public unsafe int HighestPriorityNonCustomObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }

    /// <summary>
    /// ArrayProperty: RoadNetworks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork> RoadNetworks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork>>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }

    /// <summary>
    /// ArrayProperty: VehicleExclusionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleExclusionVolume> VehicleExclusionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleExclusionVolume>>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// IntProperty: VehicleExclusionVolumesModCount
    /// </summary>
    public unsafe int VehicleExclusionVolumesModCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }
    }

    /// <summary>
    /// ArrayProperty: FilteredVehicleExclusionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FFilteredVehicleExclusionVolume> FilteredVehicleExclusionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FFilteredVehicleExclusionVolume>>(Ptr + 3396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3396); }
    }

    /// <summary>
    /// ArrayProperty: FireflyExclusionVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFireflyRoadExclusionVolume> FireflyExclusionVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFireflyRoadExclusionVolume>>(Ptr + 3412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3412); }
    }

    /// <summary>
    /// ArrayProperty: TakeoverVideoScreens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRemoteTakeoverVideoScreenInterface> TakeoverVideoScreens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRemoteTakeoverVideoScreenInterface>>(Ptr + 3428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3428); }
    }

    /// <summary>
    /// FloatProperty: lastVideoScreenTakeoverTime
    /// </summary>
    public unsafe float lastVideoScreenTakeoverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3444); }
    }

    /// <summary>
    /// ArrayProperty: BreakableVentLights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBreakableVentLightBase> BreakableVentLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBreakableVentLightBase>>(Ptr + 3448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }
    }

    /// <summary>
    /// ArrayProperty: AllJokerSwappables
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerSwappableBase> AllJokerSwappables
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerSwappableBase>>(Ptr + 3464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }
    }

    /// <summary>
    /// ArrayProperty: CurrentlyJokerfiedSwappables
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerSwappableBase> CurrentlyJokerfiedSwappables
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerSwappableBase>>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableChance_Ch3
    /// </summary>
    public unsafe float jokerSwappableChance_Ch3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableChance_Ch5
    /// </summary>
    public unsafe float jokerSwappableChance_Ch5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableChance_Ch7
    /// </summary>
    public unsafe float jokerSwappableChance_Ch7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableChance_Ch9
    /// </summary>
    public unsafe float jokerSwappableChance_Ch9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3508); }
    }

    /// <summary>
    /// FloatProperty: jokerSwappableCooldownTime
    /// </summary>
    public unsafe float jokerSwappableCooldownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// FloatProperty: lastOnScreenJokerfyTime
    /// </summary>
    public unsafe float lastOnScreenJokerfyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }

    /// <summary>
    /// FloatProperty: onScreenJokerfy_LightningDist
    /// </summary>
    public unsafe float onScreenJokerfy_LightningDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }
    }

    /// <summary>
    /// FloatProperty: onScreenJokerfy_MaxDist
    /// </summary>
    public unsafe float onScreenJokerfy_MaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3524); }
    }

    /// <summary>
    /// FloatProperty: onScreenJokerfy_MinInterval
    /// </summary>
    public unsafe float onScreenJokerfy_MinInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }
    }

    /// <summary>
    /// FloatProperty: jokerMeshSwapDuration
    /// </summary>
    public unsafe float jokerMeshSwapDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3532); }
    }

    /// <summary>
    /// ArrayProperty: Vehicles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicle> Vehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicle>>(Ptr + 3536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }
    }

    /// <summary>
    /// IntProperty: VehicleRoundRobinIndex
    /// </summary>
    public unsafe int VehicleRoundRobinIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// ArrayProperty: DeadVehicles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDeadVehicle> DeadVehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDeadVehicle>>(Ptr + 3556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3556); }
    }

    /// <summary>
    /// IntProperty: DeadVehicleRoundRobinIndex
    /// </summary>
    public unsafe int DeadVehicleRoundRobinIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3572); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileRemoteVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBatmobileRemoteVolume> BatmobileRemoteVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBatmobileRemoteVolume>>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ArrayProperty: VehicleAntiLevelVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleAntiLevelVolume> VehicleAntiLevelVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleAntiLevelVolume>>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// ArrayProperty: ActiveSmokeScreens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSmokeScreen> ActiveSmokeScreens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSmokeScreen>>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ArrayProperty: PredVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPredatorVolume> PredVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPredatorVolume>>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ArrayProperty: VehiclePassengersToSpawn
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehiclePassengerSpawnInfo> VehiclePassengersToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehiclePassengerSpawnInfo>>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ArrayProperty: ScenarioVehiclesToSpawn
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioSpawnInfo> ScenarioVehiclesToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioSpawnInfo>>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// IntProperty: DeferredSpawnFrame
    /// </summary>
    public unsafe int DeferredSpawnFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// ArrayProperty: VehiclesToInit
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleInitInfo> VehiclesToInit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleInitInfo>>(Ptr + 3676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3676); }
    }

    /// <summary>
    /// IntProperty: DeferredVehicleInitFrame
    /// </summary>
    public unsafe int DeferredVehicleInitFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// ArrayProperty: LoadedAllTheTimeOnPCToSaveDVDSpace
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> LoadedAllTheTimeOnPCToSaveDVDSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// FloatProperty: PredChaseTime
    /// </summary>
    public unsafe float PredChaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelTransition> LevelTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelTransition>>(Ptr + 3716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3716); }
    }

    /// <summary>
    /// FloatProperty: LastExclaimTime
    /// </summary>
    public unsafe float LastExclaimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3732); }
    }

    /// <summary>
    /// IntProperty: LastExclaimPriority
    /// </summary>
    public unsafe int LastExclaimPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// FloatProperty: CombatGrapnelToVPointStartTime
    /// </summary>
    public unsafe float CombatGrapnelToVPointStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// ArrayProperty: ActiveHelicopters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase> ActiveHelicopters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase>>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// IntProperty: HelicopterTimesliceIndex
    /// </summary>
    public unsafe int HelicopterTimesliceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }

    /// <summary>
    /// ArrayProperty: CurrentBatmobileForensicSideStories
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_BatmobileForensicsSideStory> CurrentBatmobileForensicSideStories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_BatmobileForensicsSideStory>>(Ptr + 3764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3764); }
    }

    /// <summary>
    /// StructProperty: ParticlePushBMPos1Mult
    /// </summary>
    public unsafe System.Numerics.Vector3 ParticlePushBMPos1Mult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3780); }
    }

    /// <summary>
    /// StructProperty: ParticlePushBMPos2Mult
    /// </summary>
    public unsafe System.Numerics.Vector3 ParticlePushBMPos2Mult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMMaxSpeed
    /// </summary>
    public unsafe float ParticlePushBMMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3804); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMMaxRange
    /// </summary>
    public unsafe float ParticlePushBMMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMMaxStrength
    /// </summary>
    public unsafe float ParticlePushBMMaxStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3812); }
    }

    /// <summary>
    /// StructProperty: ParticlePushBMBLPos1Mult
    /// </summary>
    public unsafe System.Numerics.Vector3 ParticlePushBMBLPos1Mult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3816); }
    }

    /// <summary>
    /// StructProperty: ParticlePushBMBLPos2Mult
    /// </summary>
    public unsafe System.Numerics.Vector3 ParticlePushBMBLPos2Mult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3828); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMBLMaxSpeed
    /// </summary>
    public unsafe float ParticlePushBMBLMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMBLMaxRange
    /// </summary>
    public unsafe float ParticlePushBMBLMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// FloatProperty: ParticlePushBMBLMaxStrength
    /// </summary>
    public unsafe float ParticlePushBMBLMaxStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3848); }
    }

    /// <summary>
    /// FloatProperty: ICStasisRange
    /// </summary>
    public unsafe float ICStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3852); }
    }

    /// <summary>
    /// FloatProperty: FullStasisRange
    /// </summary>
    public unsafe float FullStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3856); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeMapList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeDesc> ChallengeMapList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeDesc>>(Ptr + 3860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3860); }
    }

    /// <summary>
    /// ArrayProperty: MostWantedSetupData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMostWantedSetup> MostWantedSetupData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMostWantedSetup>>(Ptr + 3876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3876); }
    }

    /// <summary>
    /// ArrayProperty: LevelVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelVolumeDesc> LevelVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelVolumeDesc>>(Ptr + 3892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3892); }
    }

    /// <summary>
    /// ArrayProperty: LevelVolumeBspNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelVolumeBsp> LevelVolumeBspNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelVolumeBsp>>(Ptr + 3908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3908); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitionList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelTransitionDesc> LevelTransitionList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelTransitionDesc>>(Ptr + 3924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3924); }
    }

    /// <summary>
    /// ArrayProperty: SubMapLocList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc> SubMapLocList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc>>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// ArrayProperty: MapElementList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements> MapElementList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements>>(Ptr + 3956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3956); }
    }

    /// <summary>
    /// ArrayProperty: MapElementItemList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem> MapElementItemList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem>>(Ptr + 3972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3972); }
    }

    /// <summary>
    /// ArrayProperty: StoryDLCList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem> StoryDLCList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem>>(Ptr + 3988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3988); }
    }

    /// <summary>
    /// FloatProperty: DebugForceGarbageTimer
    /// </summary>
    public unsafe float DebugForceGarbageTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// ArrayProperty: DLCBundlesInstalled
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DLCBundlesInstalled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 4008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }
    }

    /// <summary>
    /// FloatProperty: CameraMovementSpeed
    /// </summary>
    public unsafe float CameraMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// StrProperty: deathMovieOverride
    /// </summary>
    public unsafe BmSDK.FString deathMovieOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// IntProperty: SavedMapIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedMapIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// IntProperty: SavedSecretIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedSecretIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }

    /// <summary>
    /// ArrayProperty: OverworldSpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> OverworldSpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 4052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4052); }
    }

    /// <summary>
    /// ArrayProperty: OverworldCarSpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> OverworldCarSpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// ArrayProperty: BrokenRiotingLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BrokenRiotingLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }

    /// <summary>
    /// ArrayProperty: objectsSettingChaseInProgress
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> objectsSettingChaseInProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// ArrayProperty: objectsSuppressingChatter
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> objectsSuppressingChatter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// StrProperty: CurrentObjectiveString
    /// </summary>
    public unsafe BmSDK.FString CurrentObjectiveString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// FloatProperty: LastCombatSuccessTime
    /// </summary>
    public unsafe float LastCombatSuccessTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// FloatProperty: lastFireflyGrenadeDamageTime
    /// </summary>
    public unsafe float lastFireflyGrenadeDamageTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// StructProperty: dialoguePlayTimes
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror dialoguePlayTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// ArrayProperty: AllGrates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase> AllGrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RTunnelGrateBase>>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// FloatProperty: IncendiaryChargeDamageTime
    /// </summary>
    public unsafe float IncendiaryChargeDamageTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// FloatProperty: lastBankSmokeBarkTime
    /// </summary>
    public unsafe float lastBankSmokeBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// ObjectProperty: SuspendAllDeadGameOver
    /// </summary>
    public unsafe BmSDK.GameObject SuspendAllDeadGameOver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// ArrayProperty: recentConversationActivationTimes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FConversationActivationTime> recentConversationActivationTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FConversationActivationTime>>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// IntProperty: NumPurchaseableUpgrades
    /// </summary>
    public unsafe int NumPurchaseableUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// ArrayProperty: StoreContent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent> StoreContent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent>>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// IntProperty: StoreContentQueryControllerId
    /// </summary>
    public unsafe int StoreContentQueryControllerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// DelegateProperty: StoreContentQueryCallback
    /// </summary>
    public unsafe System.IntPtr StoreContentQueryCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// FloatProperty: StoreContentQueryTime
    /// </summary>
    public unsafe float StoreContentQueryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// ArrayProperty: DefaultBatgirlKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultBatgirlKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }

    /// <summary>
    /// ArrayProperty: DefaultRedHoodKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultRedHoodKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// ArrayProperty: DefaultHarleyKeyMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap> DefaultHarleyKeyMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FKeyMap>>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }

    /// <summary>
    /// ArrayProperty: LevelVolumeListBatchBase
    /// </summary>
    public unsafe BmSDK.TArray<int> LevelVolumeListBatchBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// ArrayProperty: LevelVolumeBspNodesBatchBase
    /// </summary>
    public unsafe BmSDK.TArray<int> LevelVolumeBspNodesBatchBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4384); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitionListBatchBase
    /// </summary>
    public unsafe BmSDK.TArray<int> LevelTransitionListBatchBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeCharacterIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeCharacterId> ChallengeCharacterIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FChallengeCharacterId>>(Ptr + 4416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4416); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeRequiredChaptersById
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRequiredChaptersByChallengeId> ChallengeRequiredChaptersById
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FRequiredChaptersByChallengeId>>(Ptr + 4432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4432); }
    }

    /// <summary>
    /// ArrayProperty: NoAssistedTakedownVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNoAssistedTakedownVolume> NoAssistedTakedownVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNoAssistedTakedownVolume>>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// ArrayProperty: FailsafeSeenSeqEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> FailsafeSeenSeqEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// ArrayProperty: FreezeTankDestroyers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFreezeTankDestroyerBase> FreezeTankDestroyers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFreezeTankDestroyerBase>>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// DelegateProperty: __SortByIndexDist__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByIndexDist__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// DelegateProperty: __OnStoreContentQueryComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnStoreContentQueryComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// DelegateProperty: __ContentBeaconManifestLoaded__Delegate
    /// </summary>
    public unsafe System.IntPtr __ContentBeaconManifestLoaded__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

}
