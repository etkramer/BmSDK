#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentOptions<br/>
/// (flags = 0)
/// </summary>
public partial class RPersistentOptions : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPersistentOptions", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPersistentOptions() { }

    /// <summary>
    /// Constructs a new RPersistentOptions
    /// </summary>
    public RPersistentOptions(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPersistentOptions Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPersistentOptions(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: TestAndGrantWBPlayConsoleUnlocks
    /// </summary>
    public unsafe void TestAndGrantWBPlayConsoleUnlocks()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.TestAndGrantWBPlayConsoleUnlocks", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetWBPlayRewardInHydra
    /// </summary>
    public unsafe void SetWBPlayRewardInHydra(BmSDK.FString FlagName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetWBPlayRewardInHydra", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
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
    /// Function: IsWBPlayRewardFlagSet
    /// </summary>
    public unsafe bool IsWBPlayRewardFlagSet(BmSDK.FString FlagName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsWBPlayRewardFlagSet", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
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
    /// Function: SetWBPlayRewardFlag
    /// </summary>
    public unsafe void SetWBPlayRewardFlag(BmSDK.FString FlagName, bool bTrue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetWBPlayRewardFlag", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrue, paramsPtr + 16);
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
    /// Function: UpdateTimeStamp
    /// </summary>
    public unsafe void UpdateTimeStamp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.UpdateTimeStamp", true);
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
    /// Function: HaveTheOptionsChanged
    /// </summary>
    public unsafe bool HaveTheOptionsChanged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.HaveTheOptionsChanged", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasKeyboardOptionsChanged
    /// </summary>
    public unsafe bool HasKeyboardOptionsChanged(bool bCheckDLC = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.HasKeyboardOptionsChanged", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckDLC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: RevertKeyboardOptions
    /// </summary>
    public unsafe void RevertKeyboardOptions(bool bRevertDLC = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.RevertKeyboardOptions", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRevertDLC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MakeCopyOfOptions
    /// </summary>
    public unsafe void MakeCopyOfOptions(bool bMakeDLCCopies = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.MakeCopyOfOptions", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMakeDLCCopies, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDefaultMouseSmoothing
    /// </summary>
    public unsafe int GetDefaultMouseSmoothing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultMouseSmoothing", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMouseSmoothing
    /// </summary>
    public unsafe int GetMouseSmoothing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetMouseSmoothing", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetMouseSmoothing
    /// </summary>
    public unsafe void SetMouseSmoothing(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetMouseSmoothing", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDefaultMouseSensitivity
    /// </summary>
    public unsafe float GetDefaultMouseSensitivity()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultMouseSensitivity", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMouseSensitivity
    /// </summary>
    public unsafe float GetMouseSensitivity()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetMouseSensitivity", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetMouseSensitivity
    /// </summary>
    public unsafe void SetMouseSensitivity(float Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetMouseSensitivity", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetControlType
    /// </summary>
    public unsafe void SetControlType(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetControlType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetControlType
    /// </summary>
    public unsafe int GetControlType(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetControlType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultControlType
    /// </summary>
    public unsafe int GetDefaultControlType(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultControlType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetSixAxis
    /// </summary>
    public unsafe void SetSixAxis(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetSixAxis", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSixAxis
    /// </summary>
    public unsafe int GetSixAxis(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetSixAxis", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultSixAxis
    /// </summary>
    public unsafe int GetDefaultSixAxis(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultSixAxis", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetBattleModeToggle
    /// </summary>
    public unsafe void SetBattleModeToggle(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetBattleModeToggle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBattleModeToggle
    /// </summary>
    public unsafe int GetBattleModeToggle(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetBattleModeToggle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultBattleModeToggle
    /// </summary>
    public unsafe int GetDefaultBattleModeToggle(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultBattleModeToggle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetVibration
    /// </summary>
    public unsafe void SetVibration(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetVibration", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetVibration
    /// </summary>
    public unsafe int GetVibration(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetVibration", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultVibration
    /// </summary>
    public unsafe int GetDefaultVibration(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultVibration", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetCameraAssist
    /// </summary>
    public unsafe void SetCameraAssist(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetCameraAssist", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCameraAssist
    /// </summary>
    public unsafe int GetCameraAssist(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetCameraAssist", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultCameraAssist
    /// </summary>
    public unsafe int GetDefaultCameraAssist(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultCameraAssist", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetAutoFlow
    /// </summary>
    public unsafe void SetAutoFlow(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetAutoFlow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAutoFlow
    /// </summary>
    public unsafe int GetAutoFlow(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetAutoFlow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultAutoFlow
    /// </summary>
    public unsafe int GetDefaultAutoFlow(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultAutoFlow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetPredatorAwareness
    /// </summary>
    public unsafe void SetPredatorAwareness(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetPredatorAwareness", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPredatorAwareness
    /// </summary>
    public unsafe int GetPredatorAwareness(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetPredatorAwareness", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultPredatorAwareness
    /// </summary>
    public unsafe int GetDefaultPredatorAwareness(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultPredatorAwareness", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetInvertBatarang
    /// </summary>
    public unsafe void SetInvertBatarang(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetInvertBatarang", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetInvertBatarang
    /// </summary>
    public unsafe int GetInvertBatarang(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetInvertBatarang", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultInvertBatarang
    /// </summary>
    public unsafe int GetDefaultInvertBatarang(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultInvertBatarang", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetInvertGlide
    /// </summary>
    public unsafe void SetInvertGlide(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetInvertGlide", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetInvertGlide
    /// </summary>
    public unsafe int GetInvertGlide(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetInvertGlide", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultInvertGlide
    /// </summary>
    public unsafe int GetDefaultInvertGlide(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultInvertGlide", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetInvertRotation
    /// </summary>
    public unsafe void SetInvertRotation(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetInvertRotation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetInvertRotation
    /// </summary>
    public unsafe int GetInvertRotation(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetInvertRotation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultInvertRotation
    /// </summary>
    public unsafe int GetDefaultInvertRotation(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultInvertRotation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetInvertLook
    /// </summary>
    public unsafe void SetInvertLook(bool bPlayer2, int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetInvertLook", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetInvertLook
    /// </summary>
    public unsafe int GetInvertLook(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetInvertLook", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDefaultInvertLook
    /// </summary>
    public unsafe int GetDefaultInvertLook(bool bPlayer2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultInvertLook", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetHints
    /// </summary>
    public unsafe void SetHints(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetHints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetHints
    /// </summary>
    public unsafe int GetHints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetHints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDefaultHints
    /// </summary>
    public unsafe int GetDefaultHints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultHints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetTutorial
    /// </summary>
    public unsafe void SetTutorial(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetTutorial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTutorial
    /// </summary>
    public unsafe int GetTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetTutorial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDefaultTutorial
    /// </summary>
    public unsafe int GetDefaultTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultTutorial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetIntensity3D
    /// </summary>
    public unsafe void SetIntensity3D(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetIntensity3D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetIntensity3D
    /// </summary>
    public unsafe int GetIntensity3D()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetIntensity3D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDefaultIntensity3D
    /// </summary>
    public unsafe int GetDefaultIntensity3D()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultIntensity3D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetEyeInversion3D
    /// </summary>
    public unsafe void SetEyeInversion3D(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetEyeInversion3D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetEyeInversion3D
    /// </summary>
    public unsafe int GetEyeInversion3D()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetEyeInversion3D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDefaultEyeInversion3D
    /// </summary>
    public unsafe int GetDefaultEyeInversion3D()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultEyeInversion3D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetRender3D
    /// </summary>
    public unsafe void SetRender3D(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetRender3D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetRender3D
    /// </summary>
    public unsafe int GetRender3D()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetRender3D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDefaultRender3D
    /// </summary>
    public unsafe int GetDefaultRender3D()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultRender3D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Apply3DSettings
    /// </summary>
    public unsafe void Apply3DSettings()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.Apply3DSettings", true);
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
    /// Function: SetVolumeMusic
    /// </summary>
    public unsafe void SetVolumeMusic(float Value, bool UserNotify = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetVolumeMusic", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserNotify, paramsPtr + 4);
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
    /// Function: GetVolumeMusic
    /// </summary>
    public unsafe int GetVolumeMusic()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetVolumeMusic", true);
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
    /// Function: GetDefaultVolumeMusic
    /// </summary>
    public unsafe int GetDefaultVolumeMusic()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultVolumeMusic", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetVolumeDialogue
    /// </summary>
    public unsafe void SetVolumeDialogue(float Value, bool UserNotify = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetVolumeDialogue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserNotify, paramsPtr + 4);
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
    /// Function: GetVolumeDialogue
    /// </summary>
    public unsafe int GetVolumeDialogue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetVolumeDialogue", true);
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
    /// Function: GetDefaultVolumeDialogue
    /// </summary>
    public unsafe int GetDefaultVolumeDialogue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultVolumeDialogue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetVolumeSFX
    /// </summary>
    public unsafe void SetVolumeSFX(float Value, bool UserNotify = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetVolumeSFX", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserNotify, paramsPtr + 4);
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
    /// Function: GetVolumeSFX
    /// </summary>
    public unsafe int GetVolumeSFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetVolumeSFX", true);
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
    /// Function: GetDefaultVolumeSFX
    /// </summary>
    public unsafe int GetDefaultVolumeSFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultVolumeSFX", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetPadSpeaker
    /// </summary>
    public unsafe void SetPadSpeaker(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetPadSpeaker", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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
    /// Function: GetPadSpeaker
    /// </summary>
    public unsafe int GetPadSpeaker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetPadSpeaker", true);
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
    /// Function: GetDefaultPadSpeaker
    /// </summary>
    public unsafe int GetDefaultPadSpeaker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultPadSpeaker", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetGamma
    /// </summary>
    public unsafe void SetGamma(float Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetGamma", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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
    /// Function: GetEngineGamma
    /// </summary>
    public unsafe float GetEngineGamma()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetEngineGamma", true);
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
    /// Function: GetGamma
    /// </summary>
    public unsafe float GetGamma()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetGamma", true);
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
    /// Function: GetDefaultGamma
    /// </summary>
    public unsafe int GetDefaultGamma()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultGamma", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetAudioDynRange
    /// </summary>
    public unsafe void SetAudioDynRange(int Value, bool AutoSetPadSpeaker = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetAudioDynRange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AutoSetPadSpeaker, paramsPtr + 4);
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
    /// Function: GetAudioDynRange
    /// </summary>
    public unsafe int GetAudioDynRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetAudioDynRange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDefaultAudioDynRange
    /// </summary>
    public unsafe int GetDefaultAudioDynRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultAudioDynRange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetEnglishVoiceCast
    /// </summary>
    public unsafe void SetEnglishVoiceCast(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetEnglishVoiceCast", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
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
    /// Function: GetEnglishVoiceCast
    /// </summary>
    public unsafe int GetEnglishVoiceCast()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetEnglishVoiceCast", true);
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
    /// Function: GetDefaultEnglishVoiceCast
    /// </summary>
    public unsafe int GetDefaultEnglishVoiceCast()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultEnglishVoiceCast", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetSubtitles
    /// </summary>
    public unsafe void SetSubtitles(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetSubtitles", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSubtitles
    /// </summary>
    public unsafe int GetSubtitles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetSubtitles", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDefaultSubtitles
    /// </summary>
    public unsafe int GetDefaultSubtitles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultSubtitles", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetExtraChallengeMedals
    /// </summary>
    public unsafe int GetExtraChallengeMedals(int iChallengeCategory)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetExtraChallengeMedals", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iChallengeCategory, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AreAnyPlayerSkinsActive
    /// </summary>
    public unsafe bool AreAnyPlayerSkinsActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.AreAnyPlayerSkinsActive", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsDefaultPlayerSkin
    /// </summary>
    public unsafe bool IsDefaultPlayerSkin(BmSDK.FString sId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsDefaultPlayerSkin", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetActivePlayerSkin
    /// </summary>
    public unsafe BmSDK.FString GetActivePlayerSkin(BmSDK.FString sId, bool bMakePlayable = default, bool bNoChangeIfPlayable = default, bool bStripToRoot = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetActivePlayerSkin", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMakePlayable, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoChangeIfPlayable, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStripToRoot, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: ClearActivePlayerSkin
    /// </summary>
    public unsafe void ClearActivePlayerSkin(BmSDK.FString sId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.ClearActivePlayerSkin", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetActivePlayerSkin
    /// </summary>
    public unsafe bool SetActivePlayerSkin(BmSDK.FString sSkin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetActivePlayerSkin", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSkin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetActivePlayerSkinId
    /// </summary>
    public unsafe BmSDK.FString GetActivePlayerSkinId(BmSDK.FString sSkin, bool bNoChangeIfPlayable = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetActivePlayerSkinId", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSkin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoChangeIfPlayable, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetDifficultyAsString
    /// </summary>
    public unsafe BmSDK.FString GetDifficultyAsString()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDifficultyAsString", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetDifficulty
    /// </summary>
    public unsafe void SetDifficulty(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetDifficulty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe int GetDifficulty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDifficulty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDefaultDifficulty
    /// </summary>
    public unsafe int GetDefaultDifficulty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultDifficulty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsNewGamePlus
    /// </summary>
    public unsafe bool IsNewGamePlus()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsNewGamePlus", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetPCControlsPage
    /// </summary>
    public unsafe void SetPCControlsPage(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetPCControlsPage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPCControlsPage
    /// </summary>
    public unsafe int GetPCControlsPage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetPCControlsPage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDefaultPCControlsPage
    /// </summary>
    public unsafe int GetDefaultPCControlsPage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDefaultPCControlsPage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetAllDefaults
    /// </summary>
    public unsafe void SetAllDefaults()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetAllDefaults", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe void Dump()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.Dump", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmobilePredSuccess
    /// </summary>
    public unsafe void BatmobilePredSuccess(int NumCombatants, float PlayerHealthPct)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.BatmobilePredSuccess", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumCombatants, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerHealthPct, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmobilePredDeath
    /// </summary>
    public unsafe void BatmobilePredDeath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.BatmobilePredDeath", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmobileCombatSuccess
    /// </summary>
    public unsafe void BatmobileCombatSuccess(int NumCombatants, float PlayerHealthPct)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.BatmobileCombatSuccess", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumCombatants, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerHealthPct, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmobileCombatDeath
    /// </summary>
    public unsafe void BatmobileCombatDeath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.BatmobileCombatDeath", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatSuccess
    /// </summary>
    public unsafe void CombatSuccess(int NumCombatants, int CombatKOsThisFight, float PlayerHealth)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.CombatSuccess", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumCombatants, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatKOsThisFight, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerHealth, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatDeath
    /// </summary>
    public unsafe void CombatDeath(int CurrentChapter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.CombatDeath", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentChapter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDeathMovieRecord
    /// </summary>
    public unsafe void AddDeathMovieRecord(BmSDK.FString movie_name, int num_variations)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.AddDeathMovieRecord", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(movie_name, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(num_variations, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDeathRecordArrayIndex
    /// </summary>
    public unsafe int GetDeathRecordArrayIndex(BmSDK.FString movie_name)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDeathRecordArrayIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(movie_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetDeathMovieVariationIndex
    /// </summary>
    public unsafe int GetDeathMovieVariationIndex(int NumVariations)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetDeathMovieVariationIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumVariations, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetChallengeNew
    /// </summary>
    public unsafe void SetChallengeNew(int ChallengeID, bool bNew)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetChallengeNew", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNew, paramsPtr + 4);
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
    /// Function: SetChallengeAwarded
    /// </summary>
    public unsafe void SetChallengeAwarded(int ChallengeID, bool bAwarded)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetChallengeAwarded", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAwarded, paramsPtr + 4);
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
    /// Function: SetChallengeDirty
    /// </summary>
    public unsafe void SetChallengeDirty(int ChallengeID, bool bDirty)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetChallengeDirty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirty, paramsPtr + 4);
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
    /// Function: SetChallengeRequirementMet
    /// </summary>
    public unsafe void SetChallengeRequirementMet(int ChallengeID, int Requirement, bool bMet)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetChallengeRequirementMet", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Requirement, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMet, paramsPtr + 8);
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
    /// Function: SetChallengeUnlocked
    /// </summary>
    public unsafe void SetChallengeUnlocked(int ChallengeID, bool bUnlocked)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetChallengeUnlocked", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnlocked, paramsPtr + 4);
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
    /// Function: SetChallengeRevealed
    /// </summary>
    public unsafe void SetChallengeRevealed(int ChallengeID, bool bRevealed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetChallengeRevealed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRevealed, paramsPtr + 4);
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
    /// Function: SetChallengeActiveCharacter
    /// </summary>
    public unsafe void SetChallengeActiveCharacter(int ChallengeID, int nCharacterId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetChallengeActiveCharacter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nCharacterId, paramsPtr + 4);
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
    /// Function: SetChallengeDefaultCharacter
    /// </summary>
    public unsafe void SetChallengeDefaultCharacter(int ChallengeID, int nCharacterId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetChallengeDefaultCharacter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nCharacterId, paramsPtr + 4);
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
    /// Function: IsChallengeNew
    /// </summary>
    public unsafe bool IsChallengeNew(int ChallengeID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsChallengeNew", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsChallengeAwarded
    /// </summary>
    public unsafe bool IsChallengeAwarded(int ChallengeID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsChallengeAwarded", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsChallengeDirty
    /// </summary>
    public unsafe bool IsChallengeDirty(int ChallengeID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsChallengeDirty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsChallengeRequirementMet
    /// </summary>
    public unsafe bool IsChallengeRequirementMet(int ChallengeID, int Requirement)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsChallengeRequirementMet", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Requirement, paramsPtr + 4);
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
    /// Function: IsChallengeUnlocked
    /// </summary>
    public unsafe bool IsChallengeUnlocked(int ChallengeID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsChallengeUnlocked", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsChallengeRevealed
    /// </summary>
    public unsafe bool IsChallengeRevealed(int ChallengeID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsChallengeRevealed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetNewChallengeCount
    /// </summary>
    public unsafe int GetNewChallengeCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetNewChallengeCount", true);
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
    /// Function: GetRevealedChallengeCount
    /// </summary>
    public unsafe int GetRevealedChallengeCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetRevealedChallengeCount", true);
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
    /// Function: GetTotalChallengesAwarded
    /// </summary>
    public unsafe int GetTotalChallengesAwarded(out int TotalPossible, bool bTraining)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetTotalChallengesAwarded", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTraining, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TotalPossible = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetTotalChallengeMedalsForCategory
    /// </summary>
    public unsafe int GetTotalChallengeMedalsForCategory(int CharacterId, byte EChallengeCategory, out int TotalPossible, out int RivalPoints)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetTotalChallengeMedalsForCategory", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EChallengeCategory, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TotalPossible = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        RivalPoints = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetTotalChallengeMedals
    /// </summary>
    public unsafe int GetTotalChallengeMedals(int CharacterId, out int TotalPossible, out int RivalPoints)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetTotalChallengeMedals", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TotalPossible = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        RivalPoints = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetChallengeRating
    /// </summary>
    public unsafe int GetChallengeRating(int ChallengeID, int CharacterId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetChallengeRating", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
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
    /// Function: GetChallengeRivalPoints
    /// </summary>
    public unsafe int GetChallengeRivalPoints(int ChallengeID, int CharacterId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetChallengeRivalPoints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
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
    /// Function: GetChallengeMedals
    /// </summary>
    public unsafe int GetChallengeMedals(int ChallengeID, int CharacterId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetChallengeMedals", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
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
    /// Function: GetChallengeScore
    /// </summary>
    public unsafe int GetChallengeScore(int ChallengeID, int CharacterId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetChallengeScore", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
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
    /// Function: GetChallengeActiveCharacter
    /// </summary>
    public unsafe int GetChallengeActiveCharacter(int ChallengeID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetChallengeActiveCharacter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
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
    /// Function: GetChallengeCharacterIndex
    /// </summary>
    public unsafe int GetChallengeCharacterIndex(int ChallengeID, int CharacterId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetChallengeCharacterIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
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
    /// Function: GetChallengeIndex
    /// </summary>
    public unsafe int GetChallengeIndex(int ChallengeID, bool bAddNew = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetChallengeIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddNew, paramsPtr + 4);
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
    /// Function: AddRedHoodKeyBind
    /// </summary>
    public unsafe void AddRedHoodKeyBind(int InId, BmSDK.FString InKey1, BmSDK.FString InKey2, int InbPrimaryCtrl = default, int InbPrimaryShift = default, int InbPrimaryAlt = default, int InbSecondaryCtrl = default, int InbSecondaryShift = default, int InbSecondaryAlt = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.AddRedHoodKeyBind", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey2, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryCtrl, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryShift, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryAlt, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryCtrl, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryShift, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryAlt, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddBatgirlKeyBind
    /// </summary>
    public unsafe void AddBatgirlKeyBind(int InId, BmSDK.FString InKey1, BmSDK.FString InKey2, int InbPrimaryCtrl = default, int InbPrimaryShift = default, int InbPrimaryAlt = default, int InbSecondaryCtrl = default, int InbSecondaryShift = default, int InbSecondaryAlt = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.AddBatgirlKeyBind", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey2, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryCtrl, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryShift, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryAlt, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryCtrl, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryShift, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryAlt, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddHarleyKeyBind
    /// </summary>
    public unsafe void AddHarleyKeyBind(int InId, BmSDK.FString InKey1, BmSDK.FString InKey2, int InbPrimaryCtrl = default, int InbPrimaryShift = default, int InbPrimaryAlt = default, int InbSecondaryCtrl = default, int InbSecondaryShift = default, int InbSecondaryAlt = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.AddHarleyKeyBind", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey2, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryCtrl, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryShift, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryAlt, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryCtrl, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryShift, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryAlt, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddBattleKeyBind
    /// </summary>
    public unsafe void AddBattleKeyBind(int InId, BmSDK.FString InKey1, BmSDK.FString InKey2, int InbPrimaryCtrl = default, int InbPrimaryShift = default, int InbPrimaryAlt = default, int InbSecondaryCtrl = default, int InbSecondaryShift = default, int InbSecondaryAlt = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.AddBattleKeyBind", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey2, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryCtrl, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryShift, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryAlt, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryCtrl, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryShift, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryAlt, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddPursuitKeyBind
    /// </summary>
    public unsafe void AddPursuitKeyBind(int InId, BmSDK.FString InKey1, BmSDK.FString InKey2, int InbPrimaryCtrl = default, int InbPrimaryShift = default, int InbPrimaryAlt = default, int InbSecondaryCtrl = default, int InbSecondaryShift = default, int InbSecondaryAlt = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.AddPursuitKeyBind", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey2, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryCtrl, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryShift, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryAlt, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryCtrl, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryShift, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryAlt, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddBatmanKeyBind
    /// </summary>
    public unsafe void AddBatmanKeyBind(int InId, BmSDK.FString InKey1, BmSDK.FString InKey2, int InbPrimaryCtrl = default, int InbPrimaryShift = default, int InbPrimaryAlt = default, int InbSecondaryCtrl = default, int InbSecondaryShift = default, int InbSecondaryAlt = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.AddBatmanKeyBind", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey2, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryCtrl, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryShift, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbPrimaryAlt, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryCtrl, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryShift, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbSecondaryAlt, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetUserSaveSlot
    /// </summary>
    public unsafe int GetUserSaveSlot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetUserSaveSlot", true);
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
    /// Function: GetUserGUID
    /// </summary>
    public unsafe BmSDK.FString GetUserGUID()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.GetUserGUID", true);
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
    /// Function: SetUserSaveSlot
    /// </summary>
    public unsafe void SetUserSaveSlot(int SlotNumber)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetUserSaveSlot", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotNumber, paramsPtr + 0);
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
    /// Function: IsOptionsFlagSet
    /// </summary>
    public unsafe bool IsOptionsFlagSet(BmSDK.FString FlagName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.IsOptionsFlagSet", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
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
    /// Function: SetOptionsFlag
    /// </summary>
    public unsafe void SetOptionsFlag(BmSDK.FString FlagName, bool bTrue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentOptions.SetOptionsFlag", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrue, paramsPtr + 16);
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
    /// Struct: FStoredKeyMap
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FStoredKeyMap
    {
        /// <summary>
        /// StrProperty: PrimaryKeyName
        /// </summary>
        public unsafe BmSDK.FString PrimaryKeyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: SecondaryKeyName
        /// </summary>
        public unsafe BmSDK.FString SecondaryKeyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: bPrimaryCtrl
        /// </summary>
        public unsafe byte bPrimaryCtrl
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ByteProperty: bPrimaryShift
        /// </summary>
        public unsafe byte bPrimaryShift
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 33); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 33); }; }
        }

        /// <summary>
        /// ByteProperty: bPrimaryAlt
        /// </summary>
        public unsafe byte bPrimaryAlt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 34); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 34); }; }
        }

        /// <summary>
        /// ByteProperty: bSecondaryCtrl
        /// </summary>
        public unsafe byte bSecondaryCtrl
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 35); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 35); }; }
        }

        /// <summary>
        /// ByteProperty: bSecondaryShift
        /// </summary>
        public unsafe byte bSecondaryShift
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ByteProperty: bSecondaryAlt
        /// </summary>
        public unsafe byte bSecondaryAlt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 37); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 37); }; }
        }
    }

    /// <summary>
    /// Enum: EControlsOptionsKeyboard_Battle
    /// </summary>
    public enum EControlsOptionsKeyboard_Battle
    {
        EControlsOptionsKeyboard_Battle_Forward = 0,
        EControlsOptionsKeyboard_Battle_Back = 1,
        EControlsOptionsKeyboard_Battle_Left = 2,
        EControlsOptionsKeyboard_Battle_Right = 3,
        EControlsOptionsKeyboard_Battle_DodgeEject = 4,
        EControlsOptionsKeyboard_Battle_Zoom = 5,
        EControlsOptionsKeyboard_Battle_RotaryCannon = 6,
        EControlsOptionsKeyboard_Battle_HeavyCannon = 7,
        EControlsOptionsKeyboard_Battle_MissileBarrage = 8,
        EControlsOptionsKeyboard_Battle_DroneHacker = 9,
        EControlsOptionsKeyboard_Battle_EMP_BlockBreaker = 10,
        EControlsOptionsKeyboard_Battle_Sonar = 11,
        EControlsOptionsKeyboard_Battle_DetectiveMode = 12,
        EControlsOptionsKeyboard_Battle_MostWantedDial = 13,
        EControlsOptionsKeyboard_Battle_WayneTech = 14,
        EControlsOptionsKeyboard_Battle_Count = 15,
        EControlsOptionsKeyboard_Battle_MAX = 16,
    }

    /// <summary>
    /// Enum: EControlsOptionsKeyboard_Pursuit
    /// </summary>
    public enum EControlsOptionsKeyboard_Pursuit
    {
        EControlsOptionsKeyboard_Pursuit_Accelerate = 0,
        EControlsOptionsKeyboard_Pursuit_Reverse = 1,
        EControlsOptionsKeyboard_Pursuit_Left = 2,
        EControlsOptionsKeyboard_Pursuit_Right = 3,
        EControlsOptionsKeyboard_Pursuit_Afterburner = 4,
        EControlsOptionsKeyboard_Pursuit_Eject = 5,
        EControlsOptionsKeyboard_Pursuit_Powerslide = 6,
        EControlsOptionsKeyboard_Pursuit_Cycleview = 7,
        EControlsOptionsKeyboard_Pursuit_BattleMode = 8,
        EControlsOptionsKeyboard_Pursuit_ExitBatmobile = 9,
        EControlsOptionsKeyboard_Pursuit_Reverse_Camera = 10,
        EControlsOptionsKeyboard_Pursuit_BlockBreaker = 11,
        EControlsOptionsKeyboard_Pursuit_WayneTech = 12,
        EControlsOptionsKeyboard_Pursuit_Count = 13,
        EControlsOptionsKeyboard_Pursuit_MAX = 14,
    }

    /// <summary>
    /// Enum: EControlsOptionsKeyboard
    /// </summary>
    public enum EControlsOptionsKeyboard
    {
        EControlsOptionsKeyboard_Batman_Forward = 0,
        EControlsOptionsKeyboard_Batman_Back = 1,
        EControlsOptionsKeyboard_Batman_Left = 2,
        EControlsOptionsKeyboard_Batman_Right = 3,
        EControlsOptionsKeyboard_Batman_Run_Evade = 4,
        EControlsOptionsKeyboard_Batman_Crouch = 5,
        EControlsOptionsKeyboard_Batman_Toggle_Crouch = 6,
        EControlsOptionsKeyboard_Batman_Zoom = 7,
        EControlsOptionsKeyboard_Batman_Aim_Gadget_Counter = 8,
        EControlsOptionsKeyboard_Batman_Use_Gadget_Strike = 9,
        EControlsOptionsKeyboard_Batman_Cape_Stun = 10,
        EControlsOptionsKeyboard_Batman_Grapple = 11,
        EControlsOptionsKeyboard_Batman_Enter_Batmobile = 12,
        EControlsOptionsKeyboard_Batman_Detective_Mode = 13,
        EControlsOptionsKeyboard_Batman_Gadget_Select = 14,
        EControlsOptionsKeyboard_Batman_Challenge_Dial = 15,
        EControlsOptionsKeyboard_Batman_MostWanted_Dial = 16,
        EControlsOptionsKeyboard_Batman_Enter_WayneTech = 17,
        EControlsOptionsKeyboard_Batman_Enter_Special_Combo_Takedown1 = 18,
        EControlsOptionsKeyboard_Batman_Enter_Special_Combo_Takedown2 = 19,
        EControlsOptionsKeyboard_Batman_Enter_Special_Combo_Takedown3 = 20,
        EControlsOptionsKeyboard_Batman_Previous_Gadget = 21,
        EControlsOptionsKeyboard_Batman_Next_Gadget = 22,
        EControlsOptionsKeyboard_Batman_Select_Gadget1 = 23,
        EControlsOptionsKeyboard_Batman_Select_Gadget2 = 24,
        EControlsOptionsKeyboard_Batman_Select_Gadget3 = 25,
        EControlsOptionsKeyboard_Batman_Select_Gadget4 = 26,
        EControlsOptionsKeyboard_Batman_Select_Gadget5 = 27,
        EControlsOptionsKeyboard_Batman_Select_Gadget6 = 28,
        EControlsOptionsKeyboard_Batman_Select_Gadget7 = 29,
        EControlsOptionsKeyboard_Batman_Select_Gadget8 = 30,
        EControlsOptionsKeyboard_Batman_Select_Gadget9 = 31,
        EControlsOptionsKeyboard_Batman_Select_Gadget10 = 32,
        EControlsOptionsKeyboard_Batman_Select_Gadget11 = 33,
        EControlsOptionsKeyboard_Batman_Select_Gadget12 = 34,
        EControlsOptionsKeyboard_Batman_Quickfire_Batarang = 35,
        EControlsOptionsKeyboard_Batman_Quickfire_Batclaw = 36,
        EControlsOptionsKeyboard_Batman_Quickfire_Explosove_Gel = 37,
        EControlsOptionsKeyboard_Batman_Quickfire_Remote_Electric_Charge = 38,
        EControlsOptionsKeyboard_Batman_Quickfire_Freeze_Blast = 39,
        EControlsOptionsKeyboard_Batman_PhotoMode = 40,
        EControlsOptionsKeyboard_Batman_Count = 41,
        EControlsOptionsKeyboard_Batman_MAX = 42,
    }

    /// <summary>
    /// Enum: EControlsOptionsKeyboard_Harley
    /// </summary>
    public enum EControlsOptionsKeyboard_Harley
    {
        EControlsOptionsKeyboard_Harley_Forward = 0,
        EControlsOptionsKeyboard_Harley_Back = 1,
        EControlsOptionsKeyboard_Harley_Left = 2,
        EControlsOptionsKeyboard_Harley_Right = 3,
        EControlsOptionsKeyboard_Harley_Run_Evade = 4,
        EControlsOptionsKeyboard_Harley_Crouch = 5,
        EControlsOptionsKeyboard_Harley_Toggle_Crouch = 6,
        EControlsOptionsKeyboard_Harley_Zoom = 7,
        EControlsOptionsKeyboard_Harley_Aim_Gadget_Counter = 8,
        EControlsOptionsKeyboard_Harley_Use_Gadget_Strike = 9,
        EControlsOptionsKeyboard_Harley_Bat_Stun = 10,
        EControlsOptionsKeyboard_Harley_Leap = 11,
        EControlsOptionsKeyboard_Harley_Psychosis_Mode = 12,
        EControlsOptionsKeyboard_Harley_Gadget_Select = 13,
        EControlsOptionsKeyboard_Harley_Enter_Special_Combo_Takedown1 = 14,
        EControlsOptionsKeyboard_Harley_Previous_Gadget = 15,
        EControlsOptionsKeyboard_Harley_Next_Gadget = 16,
        EControlsOptionsKeyboard_Harley_Select_Gadget1 = 17,
        EControlsOptionsKeyboard_Harley_Select_Gadget2 = 18,
        EControlsOptionsKeyboard_Harley_Select_Gadget3 = 19,
        EControlsOptionsKeyboard_Harley_Snare_Trap = 20,
        EControlsOptionsKeyboard_Harley_Quickfire_JackInTheBox = 21,
        EControlsOptionsKeyboard_Harley_Mayhem_Mode = 22,
        EControlsOptionsKeyboard_Harley_PhotoMode = 23,
        EControlsOptionsKeyboard_Harley_Summary = 24,
        EControlsOptionsKeyboard_Harley_Count = 25,
        EControlsOptionsKeyboard_Harley_MAX = 26,
    }

    /// <summary>
    /// Enum: EControlsOptionsKeyboard_RedHood
    /// </summary>
    public enum EControlsOptionsKeyboard_RedHood
    {
        EControlsOptionsKeyboard_RedHood_Forward = 0,
        EControlsOptionsKeyboard_RedHood_Back = 1,
        EControlsOptionsKeyboard_RedHood_Left = 2,
        EControlsOptionsKeyboard_RedHood_Right = 3,
        EControlsOptionsKeyboard_RedHood_Run_Evade = 4,
        EControlsOptionsKeyboard_RedHood_Crouch = 5,
        EControlsOptionsKeyboard_RedHood_Toggle_Crouch = 6,
        EControlsOptionsKeyboard_RedHood_Zoom = 7,
        EControlsOptionsKeyboard_RedHood_Aim_Gadget_Counter = 8,
        EControlsOptionsKeyboard_RedHood_Use_Gadget_Strike = 9,
        EControlsOptionsKeyboard_RedHood_Kick_Stun = 10,
        EControlsOptionsKeyboard_RedHood_Grapple = 11,
        EControlsOptionsKeyboard_RedHood_Tactical_Mode = 12,
        EControlsOptionsKeyboard_RedHood_Gadget_Select = 13,
        EControlsOptionsKeyboard_RedHood_Enter_Special_Combo_Takedown1 = 14,
        EControlsOptionsKeyboard_RedHood_Previous_Gadget = 15,
        EControlsOptionsKeyboard_RedHood_Next_Gadget = 16,
        EControlsOptionsKeyboard_RedHood_Select_Gadget1 = 17,
        EControlsOptionsKeyboard_RedHood_Select_Gadget2 = 18,
        EControlsOptionsKeyboard_RedHood_Select_Gadget3 = 19,
        EControlsOptionsKeyboard_RedHood_Quickfire_HandGuns = 20,
        EControlsOptionsKeyboard_RedHood_Quickfire_ZipKick = 21,
        EControlsOptionsKeyboard_RedHood_Quickfire_FlashBang = 22,
        EControlsOptionsKeyboard_RedHood_PhotoMode = 23,
        EControlsOptionsKeyboard_RedHood_Summary = 24,
        EControlsOptionsKeyboard_RedHood_Count = 25,
        EControlsOptionsKeyboard_RedHood_MAX = 26,
    }

    /// <summary>
    /// Enum: EControlsOptionsKeyboard_Batgirl
    /// </summary>
    public enum EControlsOptionsKeyboard_Batgirl
    {
        EControlsOptionsKeyboard_Batgirl_Forward = 0,
        EControlsOptionsKeyboard_Batgirl_Back = 1,
        EControlsOptionsKeyboard_Batgirl_Left = 2,
        EControlsOptionsKeyboard_Batgirl_Right = 3,
        EControlsOptionsKeyboard_Batgirl_Run_Evade = 4,
        EControlsOptionsKeyboard_Batgirl_Crouch = 5,
        EControlsOptionsKeyboard_Batgirl_Toggle_Crouch = 6,
        EControlsOptionsKeyboard_Batgirl_Zoom = 7,
        EControlsOptionsKeyboard_Batgirl_Aim_Gadget_Counter = 8,
        EControlsOptionsKeyboard_Batgirl_Use_Gadget_Strike = 9,
        EControlsOptionsKeyboard_Batgirl_Cape_Stun = 10,
        EControlsOptionsKeyboard_Batgirl_Grapple = 11,
        EControlsOptionsKeyboard_Batgirl_Detective_Mode = 12,
        EControlsOptionsKeyboard_Batgirl_Gadget_Select = 13,
        EControlsOptionsKeyboard_Batgirl_Enter_WayneTech = 14,
        EControlsOptionsKeyboard_Batgirl_Enter_Special_Combo_Takedown1 = 15,
        EControlsOptionsKeyboard_Batgirl_Previous_Gadget = 16,
        EControlsOptionsKeyboard_Batgirl_Next_Gadget = 17,
        EControlsOptionsKeyboard_Batgirl_Select_Gadget1 = 18,
        EControlsOptionsKeyboard_Batgirl_Select_Gadget2 = 19,
        EControlsOptionsKeyboard_Batgirl_Select_Gadget3 = 20,
        EControlsOptionsKeyboard_Batgirl_Select_Gadget4 = 21,
        EControlsOptionsKeyboard_Batgirl_Select_Gadget5 = 22,
        EControlsOptionsKeyboard_Batgirl_Select_Gadget6 = 23,
        EControlsOptionsKeyboard_Batgirl_Quickfire_Batarang = 24,
        EControlsOptionsKeyboard_Batgirl_Quickfire_Batclaw = 25,
        EControlsOptionsKeyboard_Batgirl_Quickfire_Explosove_Gel = 26,
        EControlsOptionsKeyboard_Batgirl_DualTakeDown = 27,
        EControlsOptionsKeyboard_Batgirl_PhotoMode = 28,
        EControlsOptionsKeyboard_Batgirl_Count = 29,
        EControlsOptionsKeyboard_Batgirl_MAX = 30,
    }

    /// <summary>
    /// IntProperty: Version
    /// </summary>
    public unsafe int Version
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: User_GUID
    /// </summary>
    public unsafe BmSDK.FString User_GUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: User_SaveSlot
    /// </summary>
    public unsafe int User_SaveSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: GeneralOptions
    /// </summary>
    public unsafe BmSDK.TArray<int> GeneralOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: Player1Options
    /// </summary>
    public unsafe BmSDK.TArray<int> Player1Options
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: Player2Options
    /// </summary>
    public unsafe BmSDK.TArray<int> Player2Options
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: OptionsFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OptionsFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: UnlockedChallenges
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FUnlockedChallenge> UnlockedChallenges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FUnlockedChallenge>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// IntProperty: CachedChallengeId
    /// </summary>
    public unsafe int CachedChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: CachedChallengeIndex
    /// </summary>
    public unsafe int CachedChallengeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: CachedChallengeCharacterId
    /// </summary>
    public unsafe int CachedChallengeCharacterId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// IntProperty: CachedChallengeCharacterIndex
    /// </summary>
    public unsafe int CachedChallengeCharacterIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: OldUpgradePointsAvailable
    /// </summary>
    public unsafe int OldUpgradePointsAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// IntProperty: OldUpgradePointsUsed
    /// </summary>
    public unsafe int OldUpgradePointsUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: OldUpgradesPurchased
    /// </summary>
    public unsafe int OldUpgradesPurchased
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StrProperty: MWRivalName
    /// </summary>
    public unsafe BmSDK.FString MWRivalName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ArrayProperty: DeathMovieRecordArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FDeathMovieRecord> DeathMovieRecordArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FDeathMovieRecord>>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ArrayProperty: ExtraProfileStrings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ExtraProfileStrings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// StructProperty: TimeStamp
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId TimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: Day
    /// </summary>
    public unsafe int Day
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: Month
    /// </summary>
    public unsafe int Month
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// IntProperty: Year
    /// </summary>
    public unsafe int Year
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: LocationID
    /// </summary>
    public unsafe int LocationID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StrProperty: DifficultyString
    /// </summary>
    public unsafe BmSDK.FString DifficultyString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// IntProperty: NewGamePlusEnabled
    /// </summary>
    public unsafe int NewGamePlusEnabled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// IntProperty: NewGamePlusStarted
    /// </summary>
    public unsafe int NewGamePlusStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: SkippedWBIDPrompt
    /// </summary>
    public unsafe int SkippedWBIDPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// IntProperty: PercentageCompleted
    /// </summary>
    public unsafe int PercentageCompleted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: UsingGamepad
    /// </summary>
    public unsafe int UsingGamepad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: DDA_DeathsInRoom
    /// </summary>
    public unsafe int DDA_DeathsInRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: DLC_BatmanMessage
    /// </summary>
    public unsafe int DLC_BatmanMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: CurrentChallengeMapPageIndex
    /// </summary>
    public unsafe int CurrentChallengeMapPageIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: CurrentChallengeMapPageItemIndex
    /// </summary>
    public unsafe int CurrentChallengeMapPageItemIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// IntProperty: Got_WBID_Bonus
    /// </summary>
    public unsafe int Got_WBID_Bonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: WBIDPrivacyGUID1
    /// </summary>
    public unsafe int WBIDPrivacyGUID1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// IntProperty: WBIDPrivacyGUID2
    /// </summary>
    public unsafe int WBIDPrivacyGUID2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// IntProperty: WBIDPrivacyGUID3
    /// </summary>
    public unsafe int WBIDPrivacyGUID3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: WBIDPrivacyGUID4
    /// </summary>
    public unsafe int WBIDPrivacyGUID4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: CombatDDA
    /// </summary>
    public unsafe float CombatDDA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// IntProperty: MaxDDAChapter
    /// </summary>
    public unsafe int MaxDDAChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// FloatProperty: MaxDDAAddition
    /// </summary>
    public unsafe float MaxDDAAddition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: StartedWithoutCW
    /// </summary>
    public unsafe byte StartedWithoutCW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ByteProperty: StatsNew
    /// </summary>
    public unsafe byte StatsNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 373); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 373); }
    }

    /// <summary>
    /// StrProperty: CharacterSkins
    /// </summary>
    public unsafe BmSDK.FString CharacterSkins
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: ActivePlayerSkins
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FActivePlayerSkin> ActivePlayerSkins
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FActivePlayerSkin>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: TotalTimePlayed
    /// </summary>
    public unsafe float TotalTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// IntProperty: PredatorAwarenessDisabled
    /// </summary>
    public unsafe int PredatorAwarenessDisabled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: WBPlayRewardFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> WBPlayRewardFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ArrayProperty: Difficulty_Strings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Difficulty_Strings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ArrayProperty: Tmp_GeneralOptions
    /// </summary>
    public unsafe BmSDK.TArray<int> Tmp_GeneralOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ArrayProperty: Tmp_Player1Options
    /// </summary>
    public unsafe BmSDK.TArray<int> Tmp_Player1Options
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: Tmp_GraphicsOptions
    /// </summary>
    public unsafe BmSDK.TArray<int> Tmp_GraphicsOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: BatmobileCombatDDA
    /// </summary>
    public unsafe float BatmobileCombatDDA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// FloatProperty: BatmobilePredDDA
    /// </summary>
    public unsafe float BatmobilePredDDA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: BeatdownsFromFloorPickup
    /// </summary>
    public unsafe int BeatdownsFromFloorPickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// IntProperty: BattleModeOptionAvailable
    /// </summary>
    public unsafe int BattleModeOptionAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// IntProperty: PursuitCount
    /// </summary>
    public unsafe int PursuitCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: BattleCount
    /// </summary>
    public unsafe int BattleCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3040); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3080); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3120); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3280); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3400); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3800); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3880); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3920); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4680); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4720); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4760); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4840); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4880); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4920); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4960); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5000); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5040); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5080); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5120); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5160); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5200); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5240); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5280); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5320); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5400); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5440); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5480); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5520); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5560); }
    }

    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5600); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5680); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5720); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5760); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5800); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5840); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5880); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6000); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6040); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6080); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6120); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6160); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6200); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6280); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6320); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6360); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6400); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6440); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6480); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6520); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6560); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6600); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6640); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6680); }
    }

    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6800); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6920); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6960); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7000); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7040); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7080); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7120); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7200); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7240); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7280); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7320); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7360); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7400); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7440); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7480); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7520); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7560); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7600); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7680); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7720); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7760); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7800); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7840); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7880); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7920); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7960); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8000); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8040); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8080); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8120); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8160); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8200); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8240); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8280); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8320); }
    }

    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8360); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8440); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8560); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8600); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8640); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8680); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8720); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8760); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8800); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8840); }
    }

    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8880); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8920); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8960); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9000); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9040); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9080); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9120); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9160); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9200); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9240); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9280); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9320); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9360); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9400); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9440); }
    }

    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9480); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9520); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9560); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9600); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9640); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9680); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9720); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9760); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9800); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9840); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9880); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9920); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9960); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10000); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10040); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10080); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10120); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10160); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10200); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10240); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10280); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10320); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10360); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10400); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10440); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10480); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10520); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10560); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10600); }
    }

    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10640); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10680); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10720); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10760); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10800); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10840); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10880); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10920); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10960); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11000); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11040); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11080); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11120); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11160); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11200); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11240); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11280); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11320); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11360); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11400); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11440); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11480); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11520); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11560); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11600); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11640); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11680); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11720); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11760); }
    }

    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11800); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11840); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11880); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11920); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11960); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12000); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12040); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12080); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12120); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12160); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12200); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12240); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12280); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12320); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12360); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12400); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12440); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12480); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12520); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12560); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12600); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12640); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12680); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12720); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12760); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12800); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12840); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12880); }
    }

    /// <summary>
    /// IntProperty: BatgirlCount
    /// </summary>
    public unsafe int BatgirlCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12920); }
    }

    /// <summary>
    /// IntProperty: RedHoodCount
    /// </summary>
    public unsafe int RedHoodCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12924); }
    }

    /// <summary>
    /// IntProperty: HarleyCount
    /// </summary>
    public unsafe int HarleyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12928); }
    }

    /// <summary>
    /// FloatProperty: MouseSensitivity
    /// </summary>
    public unsafe float MouseSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12932); }
    }

    /// <summary>
    /// FloatProperty: MinMouseSensitivity
    /// </summary>
    public unsafe float MinMouseSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12936); }
    }

    /// <summary>
    /// FloatProperty: MaxMouseSensitivity
    /// </summary>
    public unsafe float MaxMouseSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12940); }
    }

    /// <summary>
    /// FloatProperty: Tmp_MouseSensitivity
    /// </summary>
    public unsafe float Tmp_MouseSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12944); }
    }

    /// <summary>
    /// IntProperty: MouseSmoothing
    /// </summary>
    public unsafe int MouseSmoothing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12948); }
    }

    /// <summary>
    /// IntProperty: Tmp_MouseSmoothing
    /// </summary>
    public unsafe int Tmp_MouseSmoothing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12952); }
    }

    /// <summary>
    /// IntProperty: BatmobilesAlwaysAvailable
    /// </summary>
    public unsafe int BatmobilesAlwaysAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12956); }
    }

    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12960); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12961); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12961); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12962); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12962); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12963); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12963); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12964); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12965); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12965); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12966); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12966); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12967); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12967); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12968); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12969); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12969); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12970); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12970); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12971); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12971); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12972); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12973); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12973); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12974); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12974); }
    }

    /// <summary>
    /// IntProperty: PerformedFiftyTakedownsInEndlessKnightAsBatman
    /// </summary>
    public unsafe int PerformedFiftyTakedownsInEndlessKnightAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12976); }
    }

    /// <summary>
    /// IntProperty: PerformedFiftyTakedownsInEndlessKnightAsCatwoman
    /// </summary>
    public unsafe int PerformedFiftyTakedownsInEndlessKnightAsCatwoman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12980); }
    }

    /// <summary>
    /// IntProperty: PerformedFiftyTakedownsInEndlessKnightAsAzrael
    /// </summary>
    public unsafe int PerformedFiftyTakedownsInEndlessKnightAsAzrael
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12984); }
    }

    /// <summary>
    /// IntProperty: CompletedCrimeAlleyWithoutTakingDamageAsBatman
    /// </summary>
    public unsafe int CompletedCrimeAlleyWithoutTakingDamageAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12988); }
    }

    /// <summary>
    /// IntProperty: CompletedCrimeAlleyWithoutTakingDamageAsRobin
    /// </summary>
    public unsafe int CompletedCrimeAlleyWithoutTakingDamageAsRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12992); }
    }

    /// <summary>
    /// IntProperty: CompletedCrimeAlleyWithoutTakingDamageAsNightwing
    /// </summary>
    public unsafe int CompletedCrimeAlleyWithoutTakingDamageAsNightwing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12996); }
    }

    /// <summary>
    /// IntProperty: CompletedMonarchTheatreWithPerfectFreeflowAsBatman
    /// </summary>
    public unsafe int CompletedMonarchTheatreWithPerfectFreeflowAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13000); }
    }

    /// <summary>
    /// IntProperty: CompletedMonarchTheatreWithPerfectFreeflowAsRobin
    /// </summary>
    public unsafe int CompletedMonarchTheatreWithPerfectFreeflowAsRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13004); }
    }

    /// <summary>
    /// IntProperty: CompletedMonarchTheatreWithPerfectFreeflowAsNightwing
    /// </summary>
    public unsafe int CompletedMonarchTheatreWithPerfectFreeflowAsNightwing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13008); }
    }

    /// <summary>
    /// IntProperty: CompletedMonarchTheatreWithPerfectFreeflowAsCatwoman
    /// </summary>
    public unsafe int CompletedMonarchTheatreWithPerfectFreeflowAsCatwoman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13012); }
    }

    /// <summary>
    /// IntProperty: CompletedBatcaveWithBeatdownsAsBatman
    /// </summary>
    public unsafe int CompletedBatcaveWithBeatdownsAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13016); }
    }

    /// <summary>
    /// IntProperty: CompletedBatcaveWithBeatdownsAsNightwing
    /// </summary>
    public unsafe int CompletedBatcaveWithBeatdownsAsNightwing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13020); }
    }

    /// <summary>
    /// IntProperty: CompletedSilentKnightWithKnockoutSmashesAsBatman
    /// </summary>
    public unsafe int CompletedSilentKnightWithKnockoutSmashesAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13024); }
    }

    /// <summary>
    /// IntProperty: CompletedSilentKnightWithKnockoutSmashesAsRobin
    /// </summary>
    public unsafe int CompletedSilentKnightWithKnockoutSmashesAsRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13028); }
    }

    /// <summary>
    /// Struct: FActivePlayerSkin
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FActivePlayerSkin
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
        /// StrProperty: Id
        /// </summary>
        public unsafe BmSDK.FString Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: Skin
        /// </summary>
        public unsafe BmSDK.FString Skin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: ActivePlayerSkin_Version
    /// </summary>
    public enum ActivePlayerSkin_Version
    {
        ActivePlayerSkin_Version_Initial = 0,
        ActivePlayerSkin_Version_MAX = 1,
    }

    /// <summary>
    /// Enum: MobileUnlocks
    /// </summary>
    public enum MobileUnlocks
    {
        MobileUnlocks_Scarecrow = 0,
        MobileUnlocks_Catwoman = 1,
        MobileUnlocks_Firecrews = 2,
        MobileUnlocks_Watchtowers = 3,
        MobileUnlocks_IslandDriving = 4,
        MobileUnlocks_Explosives = 5,
        MobileUnlocks_Banks = 6,
        MobileUnlocks_RiddlerChallenges = 7,
        MobileUnlocks_PenguinCaches = 8,
        MobileUnlocks_Supervillains = 9,
        MobileUnlocks_Count = 10,
        MobileUnlocks_MAX = 11,
    }

    /// <summary>
    /// Struct: FUnlockedChallenge
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FUnlockedChallenge
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
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: Status
        /// </summary>
        public unsafe byte Status
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: Requirements
        /// </summary>
        public unsafe byte Requirements
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 9); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9); }; }
        }

        /// <summary>
        /// ArrayProperty: DataPerCharacter
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FUnlockedChallengePerCharacter> DataPerCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FUnlockedChallengePerCharacter>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: ActiveCharacterId
        /// </summary>
        public unsafe int ActiveCharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: DefaultCharacterId
        /// </summary>
        public unsafe int DefaultCharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Enum: ChallengePerCharacter_Version
    /// </summary>
    public enum ChallengePerCharacter_Version
    {
        ChallengePerCharacter_Version_Initial = 0,
        ChallengePerCharacter_Version_Requirements = 1,
        ChallengePerCharacter_Version_Active = 2,
        ChallengePerCharacter_Version_Default = 3,
        ChallengePerCharacter_Version_MAX = 4,
    }

    /// <summary>
    /// Struct: FUnlockedChallengePerCharacter
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FUnlockedChallengePerCharacter
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
        /// IntProperty: LocalRating
        /// </summary>
        public unsafe int LocalRating
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: CustomLocalRating
        /// </summary>
        public unsafe int CustomLocalRating
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: CustomScore
        /// </summary>
        public unsafe int CustomScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: Medals
        /// </summary>
        public unsafe byte Medals
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: CustomMedals
        /// </summary>
        public unsafe byte CustomMedals
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 21); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21); }; }
        }

        /// <summary>
        /// ByteProperty: CharacterId
        /// </summary>
        public unsafe byte CharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 22); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22); }; }
        }

        /// <summary>
        /// IntProperty: RivalPoints
        /// </summary>
        public unsafe int RivalPoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: ChallengePerCharacter_Data_Version
    /// </summary>
    public enum ChallengePerCharacter_Data_Version
    {
        ChallengePerCharacter_Data_Version_Initial = 0,
        ChallengePerCharacter_Data_Version_MAX = 1,
    }

    /// <summary>
    /// Enum: EPlayerOptions
    /// </summary>
    public enum EPlayerOptions
    {
        EPlayerOption_InvertMouse = 0,
        EPlayerOption_InvertRotation = 1,
        EPlayerOption_InvertGlide = 2,
        EPlayerOption_InvertBatarang = 3,
        EPlayerOption_Autoflow = 4,
        EPlayerOption_CameraAssist = 5,
        EPlayerOption_Vibration = 6,
        EPlayerOption_SouthPaw = 7,
        EPlayerOption_SixAxis = 8,
        EPlayerOption_ControlType = 9,
        EPlayerOption_BattleModeToggle = 10,
        EPlayerOption_PredatorAwareness = 11,
        EPlayerOption_MAX = 12,
    }

    /// <summary>
    /// Enum: EGeneralOptions
    /// </summary>
    public enum EGeneralOptions
    {
        ECommonOption_Difficulty = 0,
        ECommonOption_PCControlsPage = 1,
        ECommonOption_Subtitles = 2,
        ECommonOption_Gamma = 3,
        ECommonOption_VolumeSFX = 4,
        ECommonOption_VolumeDialogue = 5,
        ECommonOption_VolumeMusic = 6,
        ECommonOption_Render3D = 7,
        ECommonOption_Hints = 8,
        ECommonOption_EyeInversion3D = 9,
        ECommonOption_Intensity3D = 10,
        ECommonOption_Tutorial = 11,
        ECommonOption_CombatEasyMode = 12,
        ECommonOption_PadSpeaker = 13,
        ECommonOption_SpeechRec = 14,
        ECommonOption_AudioDynRange = 15,
        ECommonOption_EnglishVoiceCast = 16,
        ECommonOption_MAX = 17,
    }

    /// <summary>
    /// Struct: FDeathMovieRecord
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FDeathMovieRecord
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
        /// StrProperty: DeathMovieName
        /// </summary>
        public unsafe BmSDK.FString DeathMovieName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: PlayCounts
        /// </summary>
        public unsafe BmSDK.TArray<byte> PlayCounts
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: DeathMovieRecord_Version
    /// </summary>
    public enum DeathMovieRecord_Version
    {
        DeathMovieRecord_Version_Initial = 0,
        DeathMovieRecord_Version_FirstTest = 1,
        DeathMovieRecord_Version_MAX = 2,
    }

    /// <summary>
    /// Enum: HelpTextLevel
    /// </summary>
    public enum HelpTextLevel
    {
        HelpText_None = 0,
        HelpText_Some = 1,
        HelpText_Full = 2,
        HelpText_MAX = 3,
    }

    /// <summary>
    /// Enum: DifficultyLevels
    /// </summary>
    public enum DifficultyLevels
    {
        Difficulty_Easy = 0,
        Difficulty_Normal = 1,
        Difficulty_Hard = 2,
        Difficulty_Knightmare = 3,
        Difficulty_MAX = 4,
    }

    /// <summary>
    /// Enum: DDAIntType
    /// </summary>
    public enum DDAIntType
    {
        DDAI_DeathsInRoom = 0,
        DDAI_MAX = 1,
    }

    /// <summary>
    /// Enum: POVersion
    /// </summary>
    public enum POVersion
    {
        POVer_Initial = 0,
        POVer_ChallengeData = 1,
        POVer_GalleryUnlocks = 2,
        POVer_LocalChallenges = 3,
        POVer_CatwomanEpisodes = 4,
        POVer_AddedNewGamePlusFlag = 5,
        POVer_MovedStuff1 = 6,
        POVer_RemovedCatwomanFlag = 7,
        POVer_AddedWBIDPrompt = 8,
        POVer_FreezeUnlockStatus = 9,
        POVer_StartedWithoutCW = 10,
        POVer_WBID_Bonus = 11,
        POVer_ChallengeUpdate1 = 12,
        POVer_LeaderboardCache = 13,
        POVer_StatsNew = 14,
        POVer_WBID_GUID = 15,
        POVer_RemovingOldBm1Bm2 = 16,
        POVer_AddedGenericTypeArrays = 17,
        POVer_CombatEasyMode = 18,
        POVer_RemovedCombatEasyMode = 19,
        POVer_LocalChallenges2 = 20,
        POVer_AddedSkinsString = 21,
        POVer_RemovedLeaderboardCache = 22,
        POVer_BatmobileDDA = 23,
        POVer_RemoveChallengeCharacterData = 24,
        POVer_BumpUpToFixCorruptSaves = 25,
        POVer_AddedSaveGameUserInfo = 26,
        POVer_PCKeyBinds = 27,
        POVer_PCKeyBindsPursuitBattle = 28,
        POVer_PCKeyBindsSerializeBattle = 29,
        POVer_PCKeyBindsWithModifierKeys = 30,
        POVer_OnceEverDialogue = 31,
        POVer_BeatdownsFromPickup = 32,
        POVer_DialogueLinePlayCount = 33,
        POVer_OnceEverDialogueRemoved = 34,
        POVer_NewPlayerSkinsData = 35,
        POVer_TimeStamp = 36,
        POVer_TotalTimePlayed = 37,
        POVer_PredatorAwareness = 38,
        POVer_PredatorAwarenessMove = 39,
        POVer_DeathMoviePlayCounts = 40,
        POVer_BattleModeOptionAvailable = 41,
        POVer_MostWantedRival = 42,
        POVer_DiffStr = 43,
        POVer_WBPlayRewardsMoved = 44,
        POVer_UpgradePointsSave = 45,
        POVer_UpgradePointsSave2 = 46,
        POVer_Flags = 47,
        POVer_RemoveDialogueLinePlayCount = 48,
        POVer_UpgradePointsSave3 = 49,
        POVer_UpgradePointsSave4 = 50,
        POVer_MoveUpgradesToPersistentShared = 51,
        POVer_PCKeyBindsDLC = 52,
        POVer_PCKeyBindsDLCEdits = 53,
        POVer_PCConfigDLCSpecialCombosRemoved = 54,
        POVer_PCMouseOptions = 55,
        POVer_NewBatmobilesData = 56,
        POVer_BluntTraumaAchievementWithARChallengeSupport = 57,
        POVer_PCPhotoMode = 58,
        POVer_PCDLCPhotoMode = 59,
        POVer_ChallengePack6Achievements = 60,
        POVer_MAX = 61,
    }
}
