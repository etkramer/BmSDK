#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineEventsInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface OnlineEventsInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: UpdatePlaylistPopulation
    /// </summary>
    public unsafe bool UpdatePlaylistPopulation(int PlaylistId, int NumPlayers);

    /// <summary>
    /// Function: UploadGameplayEventsData
    /// </summary>
    public unsafe bool UploadGameplayEventsData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.TArray<byte> Payload);

    /// <summary>
    /// Function: UploadPlayerData
    /// </summary>
    public unsafe bool UploadPlayerData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, BmSDK.FString PlayerNick, BmSDK.Engine.OnlineProfileSettings ProfileSettings, BmSDK.Engine.OnlinePlayerStorage PlayerStorage);
}
