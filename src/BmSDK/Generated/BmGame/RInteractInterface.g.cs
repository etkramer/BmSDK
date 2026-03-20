#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RInteractInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RInteractInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: AllowLongRangeInteraction
    /// </summary>
    public unsafe bool AllowLongRangeInteraction(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: GetInteractButton
    /// </summary>
    public unsafe BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton GetInteractButton(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: GetUpperPrompt
    /// </summary>
    public unsafe BmSDK.FString GetUpperPrompt();

    /// <summary>
    /// Function: OverridesRun
    /// </summary>
    public unsafe float OverridesRun(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: CanReachItem
    /// </summary>
    public unsafe bool CanReachItem(BmSDK.Engine.Pawn CheckingPawn);

    /// <summary>
    /// Function: OverridePreviousLines
    /// </summary>
    public unsafe bool OverridePreviousLines();

    /// <summary>
    /// Function: GetLocationOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 GetLocationOffset();

    /// <summary>
    /// Function: CanUseInCinematicMode
    /// </summary>
    public unsafe bool CanUseInCinematicMode();

    /// <summary>
    /// Function: Interact
    /// </summary>
    public unsafe void Interact(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: MustBeCrouched
    /// </summary>
    public unsafe bool MustBeCrouched(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: IsButtonPrompt
    /// </summary>
    public unsafe bool IsButtonPrompt();

    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe bool IsActive(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: GetPriority
    /// </summary>
    public unsafe float GetPriority();

    /// <summary>
    /// Function: GetFOVDegrees
    /// </summary>
    public unsafe float GetFOVDegrees(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: GetHeightRange
    /// </summary>
    public unsafe float GetHeightRange();

    /// <summary>
    /// Function: GetRange
    /// </summary>
    public unsafe float GetRange();

    /// <summary>
    /// Function: GetPrompt
    /// </summary>
    public unsafe BmSDK.FString GetPrompt(BmSDK.Engine.PlayerController PC);

    /// <summary>
    /// Enum: EInteractableItemFaceButton
    /// </summary>
    public enum EInteractableItemFaceButton
    {
        EIIFB_Interact = 0,
        EIIFB_Strike = 1,
        EIIFB_Counter = 2,
        EIIFB_Stun = 3,
        EIIFB_InteractHold = 4,
        EIIFB_CallBatmobile = 5,
        EIIFB_MAX = 6,
    }
}
