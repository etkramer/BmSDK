#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RRemoteControlLowSecurityInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RRemoteControlLowSecurityInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: TriggerRight
    /// </summary>
    public unsafe void TriggerRight(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: TriggerLeft
    /// </summary>
    public unsafe void TriggerLeft(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: TriggerSecondary
    /// </summary>
    public unsafe bool TriggerSecondary(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: Trigger
    /// </summary>
    public unsafe bool Trigger(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: RequiresBlindDroneUpgrade
    /// </summary>
    public unsafe bool RequiresBlindDroneUpgrade();

    /// <summary>
    /// Function: CanTrigger
    /// </summary>
    public unsafe bool CanTrigger(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: CanBeTargettedByRHD
    /// </summary>
    public unsafe bool CanBeTargettedByRHD(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: GetMiniGameHelpPrompt
    /// </summary>
    public unsafe void GetMiniGameHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn);

    /// <summary>
    /// Function: CanTargetTroughWalls
    /// </summary>
    public unsafe bool CanTargetTroughWalls();

    /// <summary>
    /// Function: GetInteractionType
    /// </summary>
    public unsafe BmSDK.BmGame.RRemoteControlLowSecurityInterface.EOmnitronInteractionType GetInteractionType();

    /// <summary>
    /// Function: GetInteractionPromptSecondary
    /// </summary>
    public unsafe BmSDK.FString GetInteractionPromptSecondary();

    /// <summary>
    /// Function: ShouldInteractionPromptBeDisplayedInCentreOfScreen
    /// </summary>
    public unsafe bool ShouldInteractionPromptBeDisplayedInCentreOfScreen();

    /// <summary>
    /// Function: GetInteractionPrompt
    /// </summary>
    public unsafe BmSDK.FString GetInteractionPrompt();

    /// <summary>
    /// Function: NeedDisplayRefresh
    /// </summary>
    public unsafe bool NeedDisplayRefresh();

    /// <summary>
    /// Function: GetDisplayIconName
    /// </summary>
    public unsafe BmSDK.FString GetDisplayIconName();

    /// <summary>
    /// Function: GetDisplayDescription
    /// </summary>
    public unsafe BmSDK.FString GetDisplayDescription();

    /// <summary>
    /// Function: GetDisplayTitle
    /// </summary>
    public unsafe BmSDK.FString GetDisplayTitle();

    /// <summary>
    /// Function: GetDisplayLockOnState
    /// </summary>
    public unsafe BmSDK.FString GetDisplayLockOnState();

    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetDisplayTargetLocation();

    /// <summary>
    /// Enum: EOmnitronInteractionType
    /// </summary>
    public enum EOmnitronInteractionType
    {
        OIT_Trigger = 0,
        OIT_TriggerPlusSecondary = 1,
        OIT_AirShipMiniGame = 2,
        OIT_MAX = 3,
    }
}
