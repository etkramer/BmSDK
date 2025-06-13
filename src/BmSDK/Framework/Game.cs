using System.Linq.Expressions;
using BmSDK.BmGame;
using BmSDK.Engine;

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
    public static Pawn GetPlayerPawn(int controllerId = 0)
    {
        var playerController = GetPlayerController(controllerId);
        return Guard.NotNull(
            (RPawnPlayer)playerController.Pawn,
            "Controller is not possessing a pawn."
        );
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
    /// Gets the global console object.
    /// </summary>
    public static _Console GetConsole()
    {
        var gameViewport = GetGameViewportClient();
        return Guard.NotNull(gameViewport.ViewportConsole);
    }

    /// <summary>
    /// Finds and returns the object with the given path. Will be null if the object hasn't been loaded yet (see <see cref="LoadPackage"/> ).
    /// </summary>
    public static unsafe T? FindObject<T>(string pathName)
        where T : GameObject, IGameObject => GameObject.FindObject(pathName, T.StaticClass()) as T;

    /// <summary>
    /// Spawns a new actor of the given type.
    /// </summary>
    public static unsafe T? SpawnActor<T>(
        GameObject.FVector position = default,
        GameObject.FRotator rotation = default,
        GameObject? owner = null
    )
        where T : Actor, IGameObject
    {
        // NOTE: SpawnActor() works only when 'bRemoteOwned' is 1, which is *not* the case for AActor::execSpawn().
        // If we wanted to get the script version working, we'd probably have to patch it.

        var world = (World)GetWorldInfo().Outer.Outer;
        var resPtr = GameFunctions.SpawnActor(
            world.Ptr,
            T.StaticClass().Ptr,
            FName.None,
            (IntPtr)(&position),
            (IntPtr)(&rotation),
            0,
            1,
            1,
            owner?.Ptr ?? 0,
            0,
            1
        );

        return MarshalUtil.ToManaged<T>(&resPtr);
    }

    /// <summary>
    /// Spawns a new actor of the given pawn and character types.
    /// </summary>
    public static unsafe TPawn? SpawnCharacter<TPawn, TCharacter>(
        GameObject.FVector Position,
        GameObject.FRotator Rotation
    )
        where TPawn : RBMPawnAI, IGameObject
        where TCharacter : RCharacter, IGameObject
    {
        return (TPawn)
            RCharacter.StaticCreatePawn(
                Position,
                Rotation,
                null,
                TPawn.StaticClass(),
                TCharacter.StaticClass(),
                true,
                FName.None,
                FName.None
            );
    }

    /// <summary>
    /// Loads a package into memory given its .upk file name.
    /// </summary>
    public static unsafe Package? LoadPackage(string Filename)
    {
        // Get TCHAR* from string
        fixed (char* filenamePtr = Filename)
        {
            // Call native func
            var result = GameFunctions.LoadPackage(0, (IntPtr)filenamePtr, 0);

            return MarshalUtil.ToManaged<Package>(&result);
        }
    }

    /// <summary>
    /// "Sets" an UnrealScript function to run your own C# code instead of the original.
    /// </summary>
    public static void SetFunctionRedirect(
        Type targetClass,
        string targetMethodName,
        Delegate newDelegate
    ) =>
        RedirectManager.RegisterRedirector(
            Class.FindByManagedType(targetClass),
            targetMethodName,
            newDelegate
        );
}
