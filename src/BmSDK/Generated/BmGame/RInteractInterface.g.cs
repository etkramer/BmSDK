#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RInteractInterface<br/>
/// (size = 44)
/// (flags = 16403)
/// </summary>
public partial interface RInteractInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetUpperPrompt
    /// </summary>
    public unsafe BmSDK.FString GetUpperPrompt();

    /// <summary>
    /// Function: OverridesRun
    /// </summary>
    public unsafe float OverridesRun(BmSDK.BmGame.RPlayerController PC);

    /// <summary>
    /// Function: UsesAttackButton
    /// </summary>
    public unsafe bool UsesAttackButton();

    /// <summary>
    /// Function: CanReachItem
    /// </summary>
    public unsafe bool CanReachItem(BmSDK.Engine.Pawn CheckingPawn);

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
    public unsafe bool MustBeCrouched();

    /// <summary>
    /// Function: IsCounterButton
    /// </summary>
    public unsafe bool IsCounterButton();

    /// <summary>
    /// Function: EitherButtonAllowed
    /// </summary>
    public unsafe bool EitherButtonAllowed();

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
    public unsafe float GetFOVDegrees();

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
}
