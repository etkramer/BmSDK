#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RSecretInterface<br/>
/// (size = 44)
/// (flags = 134234259)
/// </summary>
public partial interface RSecretInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: UseSecretLocation
    /// </summary>
    public unsafe bool UseSecretLocation();

    /// <summary>
    /// Function: GetSecretLocationY
    /// </summary>
    public unsafe int GetSecretLocationY();

    /// <summary>
    /// Function: GetSecretLocationX
    /// </summary>
    public unsafe int GetSecretLocationX();

    /// <summary>
    /// Function: GetSecretZone
    /// </summary>
    public unsafe byte GetSecretZone();

    /// <summary>
    /// Function: GetSecretPickupIndex
    /// </summary>
    public unsafe int GetSecretPickupIndex();

    /// <summary>
    /// Function: GetSecretSubType
    /// </summary>
    public unsafe BmSDK.FString GetSecretSubType();

    /// <summary>
    /// Function: GetSecretName
    /// </summary>
    public unsafe BmSDK.FString GetSecretName();

    /// <summary>
    /// Function: IsValidSecret
    /// </summary>
    public unsafe bool IsValidSecret();
}
