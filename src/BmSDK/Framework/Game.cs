using BmSDK.BmGame;
using BmSDK.Engine;

namespace BmSDK.Framework;

public static class Game
{
    /// <summary>
    /// Gets the world info object for the currently-loaded world.
    /// </summary>
    public static AWorldInfo GetWorldInfo() => Guard.NotNull(AWorldInfo.GetWorldInfo());

    /// <summary>
    /// Gets the player controller belonging to the local player.
    /// </summary>
    public static ARPlayerController GetPlayerController(int controllerId = 0)
    {
        var player = GetGameViewportClient().FindPlayerByControllerId(controllerId);
        return Guard.NotNull(player.Actor as ARPlayerController);
    }

    /// <summary>
    /// Gets the pawn currently possessed by the local player controller (returned by <see cref="GetPlayerController"/>).
    /// </summary>
    public static APawn GetPlayerPawn(int controllerId = 0)
    {
        var playerController = GetPlayerController(controllerId);
        return Guard.NotNull(playerController.Pawn, "Controller is not possessing a pawn.");
    }

    /// <summary>
    /// Gets (or creates if needed) the cheat manager owned by the local player controller (returned by <see cref="GetPlayerController"/>).
    /// </summary>
    public static URCheatManager GetCheatManager()
    {
        var playerController = GetPlayerController();
        playerController.CheatManager ??= new URCheatManager(playerController);

        return (URCheatManager)playerController.CheatManager;
    }

    /// <summary>
    /// Gets the game info object for the currently-loaded world.
    /// </summary>
    public static ARGameInfo GetGameInfo()
    {
        var worldInfo = GetWorldInfo();
        return Guard.NotNull(worldInfo.Game as ARGameInfo);
    }

    /// <summary>
    /// Gets the replication info object for the currently-loaded world.
    /// </summary>
    public static ARGameRI GetGameRI()
    {
        var worldInfo = GetWorldInfo();
        return Guard.NotNull(worldInfo.GRI as ARGameRI);
    }

    public static T? SpawnActor<T>(
        FName InName,
        UObject.FVector Position = default,
        UObject.FRotator Rotation = default
    )
        where T : AActor, IStaticObject
    {
        return GetWorldInfo().Spawn(T.StaticClass(), null, InName, Position, Rotation, null, true)
            as T;
    }

    /// <summary>
    /// Gets the global engine object.
    /// </summary>
    public static UGameEngine GetEngine() => Guard.NotNull(UEngine.GetEngine() as UGameEngine);

    /// <summary>
    /// Gets the global viewport client object.
    /// </summary>
    public static URGFxGameViewportClient GetGameViewportClient()
    {
        var engine = GetEngine();
        return Guard.NotNull(engine.GameViewport as URGFxGameViewportClient);
    }

    /// <summary>
    /// Gets the global console object.
    /// </summary>
    public static UConsole GetConsole()
    {
        var gameViewport = GetGameViewportClient();
        return Guard.NotNull(gameViewport.ViewportConsole);
    }
}
