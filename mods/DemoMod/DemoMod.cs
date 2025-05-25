using BmSDK;
using BmSDK.BmScript;
using BmSDK.Engine;
using BmSDK.Framework;

namespace DemoMod;

public class DemoMod : GameMod
{
    public override void OnInit()
    {
        // Boost snow intensity
        var defaultRainComponent = UObject.FindObjects<URRainComponent>().First();
        defaultRainComponent.ParticleCount *= 5;

        Debug.Log($"abs(-5) = {UObject.Abs(-5)}");
    }

    public override void OnKeyDown(Keys key)
    {
        // Debug actions based on key press.
        if (key == Keys.Enter)
        {
            Debug.Log("Entering game");
            DebugLoadGame();
        }
        else if (key == Keys.T)
        {
            Debug.Log("Spawning P2");
            DebugAddSplitScreenPlayer();
        }
        else if (key == Keys.R)
        {
            TestSpawnActor();
        }
    }

    private static void TestSpawnActor()
    {
        // Print some game info
        var gri = Game.GetGameRI();
        Debug.Log(gri.GetCurrentAreaName());
        Debug.Log(gri.GameMode);
        foreach (var player in gri.PlayerList)
        {
            Debug.Log($"  {player}");
        }

        // Grab player pawn
        var playerPawn = Game.GetPlayerPawn();

        // TODO: Let's get this working
        var spawnClass = ARCinematicBatman.StaticClass();
        var spawnPos = playerPawn.Location;
        var spawnRot = playerPawn.Rotation;
        spawnPos.Y += 100;

        // Spawn the actor
        var newActor = playerPawn.Spawn(
            spawnClass,
            default,
            default,
            spawnPos,
            spawnRot,
            default,
            true
        );
        Debug.Log($"Spawned actor {newActor?.ToString() ?? "NULL"}");
    }

    private static void DebugLoadGame()
    {
        var console = UObject.FindObjects<UConsole>().Last();
        console.ConsoleCommand(
            "start batentry?Players=Playable_Batman?Area=Church?Flags=Vertical_Slice?Chapters=1,2?unlockall"
        );
    }

    private static void DebugAddSplitScreenPlayer()
    {
        var gameViewport = UObject.FindObjects<UGameViewportClient>().Last();
        gameViewport.DesiredSplitscreenType = UGameViewportClient.ESplitScreenType.eSST_2P_VERTICAL;
        gameViewport.CreatePlayer(1, "fun", true);

        // TODO: Fix TArray stride
        // foreach (var info in gameViewport.SplitscreenInfo)
        // {
        //     Debug.Log($"Begin FSplitScreenData");
        //     foreach (var playerData in info.PlayerData)
        //     {
        //         Debug.Log($"  Begin FPerPlayerSplitScreenData");
        //         Debug.Log($"    SizeX {playerData.SizeX}");
        //         Debug.Log($"    SizeY {playerData.SizeY}");
        //         Debug.Log($"    OriginX {playerData.OriginX}");
        //         Debug.Log($"    OriginY {playerData.OriginY}");
        //         Debug.Log($"  End FPerPlayerSplitScreenData");
        //     }
        //     Debug.Log($"End FSplitScreenData");
        // }
    }
}
