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

    /// <summary>
    /// Spawns a new actor of the given type.
    /// </summary>
    public static unsafe T? SpawnActor<T>(
        FName InName,
        UObject.FVector Position,
        UObject.FRotator Rotation,
        UObject? Owner = null
    )
        where T : AActor, IStaticObject
    {
        // NOTE: SpawnActor() works only when 'bRemoteOwned' is 1, which is *not* the case for AActor::execSpawn().
        // If we wanted to get the script version working, we'd probably have to patch it.

        var world = (UWorld)GetWorldInfo().Outer.Outer;
        var resPtr = GameFunctions.SpawnActor(
            world.Ptr,
            T.StaticClass().Ptr,
            InName,
            (IntPtr)(&Position),
            (IntPtr)(&Rotation),
            0,
            1,
            1,
            Owner?.Ptr ?? 0,
            0,
            1
        );

        return MarshalUtil.ToManaged<T>(&resPtr);
    }

    /// <summary>
    /// Spawns a new actor of the given pawn and character types.
    /// </summary>
    public static unsafe TPawn? SpawnCharacter<TPawn, TCharacter>(
        UObject.FVector Position,
        UObject.FRotator Rotation
    )
        where TPawn : ARBMPawnAI, IStaticObject
        where TCharacter : URCharacter, IStaticObject
    {
        return (TPawn)
            URCharacter.StaticCreatePawn(
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
    public static unsafe UPackage? LoadPackage(string Filename)
    {
        // Get TCHAR* from string
        fixed (char* filenamePtr = Filename)
        {
            // Call native func
            var result = GameFunctions.LoadPackage(0, (IntPtr)filenamePtr, 0);

            return MarshalUtil.ToManaged<UPackage>(&result);
        }
    }
}
