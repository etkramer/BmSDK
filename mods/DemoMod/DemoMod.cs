using BmSDK;
using BmSDK.BmGame;
using BmSDK.Engine;

namespace DemoMod;

public class DemoMod : GameMod
{
    public override void OnInit()
    {
        // Boost snow intensity
        var defaultRainComponent = UObject.FindObjectsSlow<URRainComponent>().First();
        defaultRainComponent.ParticleCount *= 5;
    }

    public override void OnEnterMenu()
    {
        // Enable info display
        Game.GetGameViewportClient().bShowSessionDebug = true;

        // Show lighting only
        Game.GetGameViewportClient().bOverrideDiffuseAndSpecular = true;
    }

    public override void OnEnterGame()
    {
        // Enable 1-hit counters
        foreach (var counterMove in UObject.FindObjectsSlow<ARCombatMove_BatmanCounter>())
        {
            counterMove.bShouldKill = true;
        }
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
        else if (key == Keys.V)
        {
            Debug.Log("Toggling ghost");
            DebugToggleGhost();
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
        foreach (var player in gri.PlayerList)
        {
            Debug.Log($"  {player}");
        }

        // Grab player pawn
        var playerPawn = Game.GetPlayerPawn();
        Debug.Log($"Player is at {playerPawn.Location}");

        // TODO: Let's get this working
        var spawnClass = APointLight.StaticClass();
        var spawnPos = playerPawn.Location with { Z = playerPawn.Location.Z + 120 };
        Debug.Log(spawnClass);

        // Spawn the actor
        // NOTE: APointLight narrows it down - it can't be a collision issue because lights are allowed to intersect.
        var newActor = Game.SpawnActor<APointLight>("TestActor", spawnPos);
        Debug.Log($"Spawned actor {newActor?.ToString() ?? "NULL"}");
    }

    private static void DebugLoadGame()
    {
        var console = Game.GetConsole();
        console.ConsoleCommand(
            "start batentry?Players=Playable_Batman?Area=Church?Flags=Vertical_Slice?Chapters=1,2?unlockall"
        );
    }

    private static void DebugToggleGhost()
    {
        var cheatManager = Game.GetCheatManager();
        cheatManager.ToggleGhost();
    }

    private static void DebugAddSplitScreenPlayer()
    {
        var gameViewport = Game.GetGameViewportClient();
        gameViewport.DesiredSplitscreenType = UGameViewportClient.ESplitScreenType.eSST_2P_VERTICAL;
        gameViewport.CreatePlayer(1, out _, true);

        Debug.Log(gameViewport.ShouldForceFullscreenViewport());
    }
}
