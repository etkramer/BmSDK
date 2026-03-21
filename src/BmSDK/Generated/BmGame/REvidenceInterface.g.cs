#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: REvidenceInterface<br/>
/// (size = 44)
/// (flags = 134234259)
/// </summary>
public partial interface REvidenceInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetEvidenceIndex
    /// </summary>
    public unsafe int GetEvidenceIndex();

    /// <summary>
    /// Function: SetMovieScanned
    /// </summary>
    public unsafe void SetMovieScanned();

    /// <summary>
    /// Function: GetSelf
    /// </summary>
    public unsafe BmSDK.GameObject GetSelf();

    /// <summary>
    /// Function: GetEvidenceInfo
    /// </summary>
    public unsafe BmSDK.BmGame.REvidence GetEvidenceInfo();

    /// <summary>
    /// Function: CanBeScanned
    /// </summary>
    public unsafe bool CanBeScanned();

    /// <summary>
    /// Function: GetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetLocation();

    /// <summary>
    /// Function: show
    /// </summary>
    public unsafe void show(float _show, int ShowMode = default);
}
