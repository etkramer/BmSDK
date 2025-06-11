using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;

namespace DemoMod;

public static class RCinematicCustomActorMixins
{
    [MixinMethod(typeof(ARCinematicCustomActor), nameof(ARCinematicCustomActor.PostBeginPlay))]
    public static void PostBeginPlay(ARCinematicCustomActor self)
    {
        // Load package with Robin's meshes
        Game.LoadPackage("Playable_Robin_Std_SF");

        // Replace cinematic Batman (head/body)
        if (self.SkeletalMeshComponent.SkeletalMesh.Name.ToString() == "Batman_Head_Skin")
        {
            var newHeadMesh = UObject.FindObject<USkeletalMesh>("Robin.Mesh.Robin_Head_Skin");
            var newBodyMesh = UObject.FindObject<USkeletalMesh>("Robin.Mesh.Robin_Staff_V2");
            self.SkeletalMeshComponent.SetSkeletalMesh(newHeadMesh);
            self.ExtraSkeletalMeshComponent1.SetSkeletalMesh(newBodyMesh);
            Debug.Log("Using Robin's head/body");
        }

        // Replace cinematic Batman (cape)
        if (self.SkeletalMeshComponent.SkeletalMesh?.Name.ToString() == "Cape_Mesh")
        {
            var newCapeMesh = UObject.FindObject<USkeletalMesh>("Robin.Mesh.Robin_Cape_V2");
            self.SkeletalMeshComponent.SetSkeletalMesh(newCapeMesh);
            Debug.Log("Using Robin's cape");
        }

        // Calling the base implementation is optional.
        self.PostBeginPlay();
    }

    [MixinMethod(typeof(ARCinematicCustomActor), nameof(ARCinematicCustomActor.BeginAnimControl))]
    public static void BeginAnimControl(ARCinematicCustomActor self, UInterpGroup inInterpGroup)
    {
        Debug.Log($"Hello from BeginAnimControl!");

        // Calling the base implementation is optional.
        self.BeginAnimControl(inInterpGroup);
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

        // Load packages we need for RPawnVillainNinja, RCharacter_Strange
        Game.LoadPackage("Under_B2_Ch4");
        Game.LoadPackage("Under_B6_Ch7");

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
