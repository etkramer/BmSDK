#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RRammableInterface<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface RRammableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: RammedByVehicle
    /// </summary>
    public unsafe bool RammedByVehicle(BmSDK.BmGame.RVehicle RammingVehicle, BmSDK.FName RammedBoneName);

    /// <summary>
    /// Function: GetMinRamSpeed
    /// </summary>
    public unsafe float GetMinRamSpeed();
}
