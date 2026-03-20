#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RExplosiveGelableInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RExplosiveGelableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: InValidPositionToPlaceGel
    /// </summary>
    public unsafe bool InValidPositionToPlaceGel(BmSDK.BmGame.RPawnPlayer Player);

    /// <summary>
    /// Function: DetonateGel
    /// </summary>
    public unsafe void DetonateGel();

    /// <summary>
    /// Function: PlaceExplosiveGel
    /// </summary>
    public unsafe bool PlaceExplosiveGel(BmSDK.BmGame.RPawnPlayer Player);
}
