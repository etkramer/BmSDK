#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RPointOfInterestInterface<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface RPointOfInterestInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: PointOfInterest_GetSideStoryReferenceName
    /// </summary>
    public unsafe BmSDK.FString PointOfInterest_GetSideStoryReferenceName();

    /// <summary>
    /// Function: PointOfInterest_GetLabelLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PointOfInterest_GetLabelLocation();

    /// <summary>
    /// Function: PointOfInterest_IsActive
    /// </summary>
    public unsafe bool PointOfInterest_IsActive();
}
