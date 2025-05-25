using BmSDK.Engine;
using BmSDK.Framework;

namespace BmSDK;

public static class Game
{
    /// <summary>
    /// Gets the world info object for the currently-loaded world.
    /// </summary>
    public static AWorldInfo GetWorldInfo() => Guard.NotNull(AWorldInfo.GetWorldInfo());

    /// <summary>
    /// Gets the player controller belonging to the local player.
    /// May return a random controller in case of split-screen.
    /// </summary>
    public static APlayerController GetPlayerController()
    {
        var worldInfo = GetWorldInfo();
        return Guard.NotNull(worldInfo.GetALocalPlayerController(), "No player controllers found.");
    }

    /// <summary>
    /// Gets the pawn currently possessed by the local player controller (returned by <see cref="GetPlayerController"/>).
    /// </summary>
    public static APawn GetPlayerPawn()
    {
        var playerController = GetPlayerController();
        return Guard.NotNull(playerController.Pawn, "Controller is not possessing a pawn.");
    }
}
