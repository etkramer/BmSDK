using System.Numerics;
using BmSDK.BmGame;
using BmSDK.Engine;
using BmSDK.Framework.Redirection;

namespace BmSDK.Framework;

public static partial class Game
{
    /// <summary>
    /// Gets the world info object for the currently-loaded world.
    /// </summary>
    public static WorldInfo GetWorldInfo() => Guard.NotNull(WorldInfo.GetWorldInfo());

    /// <summary>
    /// Gets the player controller belonging to the local player.
    /// </summary>
    public static RPlayerController GetPlayerController(int controllerId = 0)
    {
        var player = GetGameViewportClient().FindPlayerByControllerId(controllerId);
        return Guard.NotNull(player.Actor as RPlayerController);
    }

    /// <summary>
    /// Gets the pawn currently possessed by the local player controller (returned by <see cref="GetPlayerController"/>).
    /// </summary>
    public static RPawnPlayer GetPlayerPawn(int controllerId = 0)
    {
        var playerController = GetPlayerController(controllerId);
        return Guard.NotNull(playerController.CombatPawn, "Controller is not possessing a pawn.");
    }

    /// <summary>
    /// Gets (or creates if needed) the cheat manager owned by the local player controller (returned by <see cref="GetPlayerController"/>).
    /// </summary>
    public static RCheatManager GetCheatManager()
    {
        var playerController = GetPlayerController();
        playerController.CheatManager ??= new RCheatManager(playerController);

        return (RCheatManager)playerController.CheatManager;
    }

    /// <summary>
    /// Gets the game info object for the currently-loaded world.
    /// </summary>
    public static RGameInfo GetGameInfo()
    {
        var worldInfo = GetWorldInfo();
        return Guard.NotNull(worldInfo.Game as RGameInfo);
    }

    /// <summary>
    /// Gets the replication info object for the currently-loaded world.
    /// </summary>
    public static RGameRI GetGameRI()
    {
        var worldInfo = GetWorldInfo();
        return Guard.NotNull(worldInfo.GRI as RGameRI);
    }

    /// <summary>
    /// Gets the persistent data object for the currently-loaded world.
    /// </summary>
    public static RPersistentData GetPersistentData()
    {
        var gameInfo = GetGameInfo();
        return Guard.NotNull(gameInfo.PersistentData);
    }

    /// <summary>
    /// Gets the population manager object for the currently-loaded world.
    /// </summary>
    public static RPopulationManager GetPopulationManager()
    {
        var gameInfo = GetGameInfo();
        return Guard.NotNull(gameInfo.PopulationManager);
    }

    /// <summary>
    /// Gets the global engine object.
    /// </summary>
    public static GameEngine GetEngine() => Guard.NotNull(_Engine.GetEngine() as GameEngine);

    /// <summary>
    /// Gets the global viewport client object.
    /// </summary>
    public static RGFxGameViewportClient GetGameViewportClient()
    {
        var engine = GetEngine();
        return Guard.NotNull(engine.GameViewport as RGFxGameViewportClient);
    }

    /// <summary>
    /// Gets (or creates if needed) the global console object.
    /// </summary>
    public static _Console GetConsole()
    {
        var gameViewport = GetGameViewportClient();
        gameViewport.ViewportConsole ??= new _Console(gameViewport);

        return Guard.NotNull(gameViewport.ViewportConsole);
    }

    /// <summary>
    /// Gets the time in seconds since the last world tick.
    /// </summary>
    public static float GetDeltaTime()
    {
        var worldInfo = GetWorldInfo();
        return worldInfo.DeltaSeconds;
    }

    /// <summary>
    /// Finds and returns the object with the given path. Will be null if the object hasn't been loaded yet (see <see cref="LoadPackage"/> ).
    /// </summary>
    public static T? FindObject<T>(string pathName)
        where T : GameObject, IGameObject => GameObject.FindObject(pathName, T.StaticClass()) as T;

    /// <summary>
    /// Loads a package into memory given its .upk file name.
    /// </summary>
    public static unsafe Package? LoadPackage(string filename)
    {
        // Get TCHAR* from string
        fixed (char* filenamePtr = filename)
        {
            // Call native func
            var result = GameFunctions.LoadPackage(0, (IntPtr)filenamePtr, 0);

            return MarshalUtil.ToManaged<Package>(&result);
        }
    }
}
