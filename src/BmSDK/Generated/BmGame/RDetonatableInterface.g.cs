#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RDetonatableInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RDetonatableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: Detonate
    /// </summary>
    public unsafe void Detonate();

    /// <summary>
    /// Function: GetDetonatePrompt
    /// </summary>
    public unsafe BmSDK.FString GetDetonatePrompt();

    /// <summary>
    /// Function: PlayDetonateAnim
    /// </summary>
    public unsafe bool PlayDetonateAnim();

    /// <summary>
    /// Function: ReadyToDetonate
    /// </summary>
    public unsafe bool ReadyToDetonate();
}
