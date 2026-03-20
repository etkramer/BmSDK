#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RRemoteControlHighSecurityInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RRemoteControlHighSecurityInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ShouldPlayBombBarks
    /// </summary>
    public unsafe bool ShouldPlayBombBarks();

    /// <summary>
    /// Function: DisallowLongRangeResonator
    /// </summary>
    public unsafe bool DisallowLongRangeResonator();

    /// <summary>
    /// Function: GetDisplayIconName
    /// </summary>
    public unsafe BmSDK.FString GetDisplayIconName();

    /// <summary>
    /// Function: GetInputDialSeed
    /// </summary>
    public unsafe int GetInputDialSeed();

    /// <summary>
    /// Function: GetPassword
    /// </summary>
    public unsafe BmSDK.FString GetPassword(int Index);

    /// <summary>
    /// Function: GetPasswordArrayLength
    /// </summary>
    public unsafe int GetPasswordArrayLength();

    /// <summary>
    /// Function: GetResonatorMinigameStringReference
    /// </summary>
    public unsafe BmSDK.FString GetResonatorMinigameStringReference();

    /// <summary>
    /// Function: GetResonatorWinScreenStringReference
    /// </summary>
    public unsafe BmSDK.FString GetResonatorWinScreenStringReference();

    /// <summary>
    /// Function: GetRawDifficulty
    /// </summary>
    public unsafe int GetRawDifficulty();

    /// <summary>
    /// Function: GetHackingTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectTargetType GetHackingTargetType();

    /// <summary>
    /// Function: GetHackingNetworkType
    /// </summary>
    public unsafe BmSDK.BmGame.RRemoteControlHighSecurityInterface.DisruptableObjectNetworkType GetHackingNetworkType();

    /// <summary>
    /// Function: GetActiveFlag
    /// </summary>
    public unsafe BmSDK.FName GetActiveFlag();

    /// <summary>
    /// Function: StopAlarmSound
    /// </summary>
    public unsafe void StopAlarmSound();

    /// <summary>
    /// Function: PlayAlarmSound
    /// </summary>
    public unsafe void PlayAlarmSound();

    /// <summary>
    /// Function: IsAlarmed
    /// </summary>
    public unsafe bool IsAlarmed();

    /// <summary>
    /// Function: GetMaximumInteractionDistance
    /// </summary>
    public unsafe float GetMaximumInteractionDistance();

    /// <summary>
    /// Function: VeryLowSecurity
    /// </summary>
    public unsafe bool VeryLowSecurity();

    /// <summary>
    /// Function: RequiresHighSecurityResonator
    /// </summary>
    public unsafe bool RequiresHighSecurityResonator();

    /// <summary>
    /// Function: GetLeftResonantPosition
    /// </summary>
    public unsafe float GetLeftResonantPosition();

    /// <summary>
    /// Function: GetRightResonantPosition
    /// </summary>
    public unsafe float GetRightResonantPosition();

    /// <summary>
    /// Function: GetDifficultyLevel
    /// </summary>
    public unsafe int GetDifficultyLevel();

    /// <summary>
    /// Function: HasMultipleStages
    /// </summary>
    public unsafe bool HasMultipleStages();

    /// <summary>
    /// Function: InResonatorThreshold
    /// </summary>
    public unsafe void InResonatorThreshold(bool InThreshold);

    /// <summary>
    /// Function: StartResonatorMinigame
    /// </summary>
    public unsafe void StartResonatorMinigame();

    /// <summary>
    /// Function: FailedToDisrupt
    /// </summary>
    public unsafe void FailedToDisrupt();

    /// <summary>
    /// Function: NextStage
    /// </summary>
    public unsafe bool NextStage();

    /// <summary>
    /// Function: WillExplode
    /// </summary>
    public unsafe bool WillExplode();

    /// <summary>
    /// Function: StillDisruptable
    /// </summary>
    public unsafe bool StillDisruptable();

    /// <summary>
    /// Function: GetIconLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetIconLocation();

    /// <summary>
    /// Function: SuccessfullyDisrupted
    /// </summary>
    public unsafe void SuccessfullyDisrupted();

    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe void GetDifficulty(out float Threshold, out float BuildUpTime, out float LeftMaxAngVelocity, out float RightMaxAngVelocity, int DifficultyMod = default);

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
