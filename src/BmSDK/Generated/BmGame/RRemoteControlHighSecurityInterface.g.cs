#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRemoteControlHighSecurityInterface<br/>
/// (flags = 0)
/// </summary>
public partial class RRemoteControlHighSecurityInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRemoteControlHighSecurityInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRemoteControlHighSecurityInterface() { }

    /// <summary>
    /// Constructs a new RRemoteControlHighSecurityInterface
    /// </summary>
    public RRemoteControlHighSecurityInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRemoteControlHighSecurityInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRemoteControlHighSecurityInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ShouldPlayBombBarks
    /// </summary>
    public unsafe bool ShouldPlayBombBarks()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.ShouldPlayBombBarks", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DisallowLongRangeResonator
    /// </summary>
    public unsafe bool DisallowLongRangeResonator()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.DisallowLongRangeResonator", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDisplayIconName
    /// </summary>
    public unsafe BmSDK.FString GetDisplayIconName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetDisplayIconName", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetInputDialSeed
    /// </summary>
    public unsafe int GetInputDialSeed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetInputDialSeed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPassword
    /// </summary>
    public unsafe BmSDK.FString GetPassword(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetPassword", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetPasswordArrayLength
    /// </summary>
    public unsafe int GetPasswordArrayLength()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetPasswordArrayLength", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetResonatorMinigameStringReference
    /// </summary>
    public unsafe BmSDK.FString GetResonatorMinigameStringReference()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetResonatorMinigameStringReference", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetResonatorWinScreenStringReference
    /// </summary>
    public unsafe BmSDK.FString GetResonatorWinScreenStringReference()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetResonatorWinScreenStringReference", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetRawDifficulty
    /// </summary>
    public unsafe int GetRawDifficulty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetRawDifficulty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHackingTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectTargetType GetHackingTargetType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetHackingTargetType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectTargetType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHackingNetworkType
    /// </summary>
    public unsafe BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectNetworkType GetHackingNetworkType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetHackingNetworkType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectNetworkType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetActiveFlag
    /// </summary>
    public unsafe BmSDK.FName GetActiveFlag()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetActiveFlag", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StopAlarmSound
    /// </summary>
    public unsafe void StopAlarmSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.StopAlarmSound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayAlarmSound
    /// </summary>
    public unsafe void PlayAlarmSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.PlayAlarmSound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsAlarmed
    /// </summary>
    public unsafe bool IsAlarmed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.IsAlarmed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMaximumInteractionDistance
    /// </summary>
    public unsafe float GetMaximumInteractionDistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetMaximumInteractionDistance", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: VeryLowSecurity
    /// </summary>
    public unsafe bool VeryLowSecurity()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.VeryLowSecurity", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RequiresHighSecurityResonator
    /// </summary>
    public unsafe bool RequiresHighSecurityResonator()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.RequiresHighSecurityResonator", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLeftResonantPosition
    /// </summary>
    public unsafe float GetLeftResonantPosition()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetLeftResonantPosition", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetRightResonantPosition
    /// </summary>
    public unsafe float GetRightResonantPosition()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetRightResonantPosition", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDifficultyLevel
    /// </summary>
    public unsafe int GetDifficultyLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetDifficultyLevel", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasMultipleStages
    /// </summary>
    public unsafe bool HasMultipleStages()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.HasMultipleStages", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: InResonatorThreshold
    /// </summary>
    public unsafe void InResonatorThreshold(bool InThreshold)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.InResonatorThreshold", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InThreshold, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartResonatorMinigame
    /// </summary>
    public unsafe void StartResonatorMinigame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.StartResonatorMinigame", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FailedToDisrupt
    /// </summary>
    public unsafe void FailedToDisrupt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.FailedToDisrupt", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NextStage
    /// </summary>
    public unsafe bool NextStage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.NextStage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: WillExplode
    /// </summary>
    public unsafe bool WillExplode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.WillExplode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StillDisruptable
    /// </summary>
    public unsafe bool StillDisruptable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.StillDisruptable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetIconLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetIconLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetIconLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SuccessfullyDisrupted
    /// </summary>
    public unsafe void SuccessfullyDisrupted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.SuccessfullyDisrupted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe void GetDifficulty(out float Threshold, out float BuildUpTime, out float LeftMaxAngVelocity, out float RightMaxAngVelocity, int DifficultyMod = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteControlHighSecurityInterface.GetDifficulty", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DifficultyMod, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Threshold = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        BuildUpTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        LeftMaxAngVelocity = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
        RightMaxAngVelocity = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Enum: DisruptableObjectTargetType
    /// </summary>
    public enum DisruptableObjectTargetType
    {
        DOTT_AccessDoor = 0,
        DOTT_ElevatorControlCall = 1,
        DOTT_ElevatorControlLower = 2,
        DOTT_ElevatorControlRaise = 3,
        DOTT_ElectrifiedFenceDeactivate = 4,
        DOTT_ElectrifiedFenceActivate = 5,
        DOTT_SecurityDoor = 6,
        DOTT_DisplayCabinet = 7,
        DOTT_ControlBox = 8,
        DOTT_TunnelAccess = 9,
        DOTT_TowerMaintenanceHatch = 10,
        DOTT_MaintenanceAccess = 11,
        DOTT_AccessBridge = 12,
        DOTT_DeadshotPda = 13,
        DOTT_RiddlerBarrier = 14,
        DOTT_RiddlerElectricFloor = 15,
        DOTT_MAX = 16,
    }

    /// <summary>
    /// Enum: DisruptableObjectNetworkType
    /// </summary>
    public enum DisruptableObjectNetworkType
    {
        DONT_GothamMunicipalNetwork = 0,
        DONT_RiddlerMatrix = 1,
        DONT_MobileElectronicDevice = 2,
        DONT_MAX = 3,
    }
}
