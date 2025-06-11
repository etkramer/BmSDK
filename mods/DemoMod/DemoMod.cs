using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;

namespace DemoMod;

public static class RCinematicCustomActorMixins
{
    [FunctionMixin(typeof(ARCinematicCustomActor), nameof(ARCinematicCustomActor.PostBeginPlay))]
    public static void PostBeginPlay(ARCinematicCustomActor self)
    {
        Debug.Log($"Hello from PostBeginPlay! Self is {self}");

        // Base implementation
        self.PostBeginPlay();
    }
}

public class DemoMod : GameMod
{
    public override void OnInit()
    {
        MixinManager.RegisterMixins(typeof(RCinematicCustomActorMixins));

        // Boost snow intensity
        var defaultRainComponent = URRainComponent.StaticClass().DefaultObject as URRainComponent;
        defaultRainComponent.ParticleCount *= 5;

        // Set max players (default and current/frontend)
        foreach (var gameInfo in UObject.FindObjectsSlow<ARGameInfo>())
        {
            gameInfo.MaxPlayers = 4;
        }
    }

    public override void OnEnterMenu()
    {
        // Enable info display
        Game.GetGameViewportClient().bShowSessionDebug = true;
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
        var playerPawn = Game.GetPlayerPawn();

        // Spawn in a pawn
        var newCharacter = Game.SpawnCharacter<ARPawnVillainNinja, URCharacter_Strange>(
            playerPawn.Location with
            {
                Y = playerPawn.Location.Y + 100,
            },
            playerPawn.Rotation
        );

        Debug.Log($"Spawned character {newCharacter?.ToString() ?? "NULL"}");
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

        // Debug.Log(gameViewport.ShouldForceFullscreenViewport());
    }
}
