#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RElectricWinchableInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RElectricWinchableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: AllowLongRangeTargeting
    /// </summary>
    public unsafe bool AllowLongRangeTargeting();

    /// <summary>
    /// Function: IsGenerator
    /// </summary>
    public unsafe bool IsGenerator();

    /// <summary>
    /// Function: ApplyRevs
    /// </summary>
    public unsafe void ApplyRevs(float Revs, BmSDK.BmGame.RPlayerController Controller);

    /// <summary>
    /// Function: GetRevsMaxDelta
    /// </summary>
    public unsafe float GetRevsMaxDelta();

    /// <summary>
    /// Function: GetRevs
    /// </summary>
    public unsafe float GetRevs();

    /// <summary>
    /// Function: ShowRevPrompt
    /// </summary>
    public unsafe bool ShowRevPrompt();

    /// <summary>
    /// Function: CustomPromptButtonPressed
    /// </summary>
    public unsafe void CustomPromptButtonPressed();

    /// <summary>
    /// Function: ShowCustomPrompt
    /// </summary>
    public unsafe bool ShowCustomPrompt();

    /// <summary>
    /// Function: AlwaysShowElectricEffectsOnCable
    /// </summary>
    public unsafe bool AlwaysShowElectricEffectsOnCable();

    /// <summary>
    /// Function: AllowElectrifyHUD
    /// </summary>
    public unsafe bool AllowElectrifyHUD();

    /// <summary>
    /// Function: IsPoweredUp
    /// </summary>
    public unsafe bool IsPoweredUp();

    /// <summary>
    /// Function: IsSideStory
    /// </summary>
    public unsafe bool IsSideStory();

    /// <summary>
    /// Function: BlocksInteraction
    /// </summary>
    public unsafe bool BlocksInteraction();

    /// <summary>
    /// Function: StopElectricityEffects
    /// </summary>
    public unsafe void StopElectricityEffects();

    /// <summary>
    /// Function: StartElectricityEffects
    /// </summary>
    public unsafe void StartElectricityEffects();

    /// <summary>
    /// Function: WinchAborted
    /// </summary>
    public unsafe void WinchAborted(int Reason);

    /// <summary>
    /// Function: WinchReleased
    /// </summary>
    public unsafe void WinchReleased(BmSDK.BmGame.RBatmobileWinch Winch);

    /// <summary>
    /// Function: WinchAttached
    /// </summary>
    public unsafe void WinchAttached(BmSDK.BmGame.RBatmobileWinch Winch);

    /// <summary>
    /// Function: GetWinchTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetWinchTargetLocation();

    /// <summary>
    /// Function: RestorePoweredUpState
    /// </summary>
    public unsafe bool RestorePoweredUpState();
}
