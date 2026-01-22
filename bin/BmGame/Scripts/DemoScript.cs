using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;

[Script]
public class DemoScript : Script
{
    public override void Main()
    {
        // Boost snow intensity
        var defaultRainComponent = RRainComponent.StaticClass().DefaultObject as RRainComponent;
        defaultRainComponent.ParticleCount *= 5;

        // Set max players (default and current/frontend)
        foreach (var gameInfo in GameObject.FindObjectsSlow<RGameInfo>())
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
        foreach (var counterMove in GameObject.FindObjectsSlow<RCombatMove_BatmanCounter>())
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

    static void TestSpawnActor()
    {
        var playerPawn = Game.GetPlayerPawn();

        // Load package we need for RCharacter_Joker
        Game.LoadPackage("FunFair");

        // Spawn in a pawn
        var newCharacter = Game.SpawnCharacter<RPawnVillainThug, RCharacter_Joker>(
            playerPawn.Location with
            {
                Y = playerPawn.Location.Y + 100,
            },
            playerPawn.Rotation
        );

        Debug.Log($"Spawned character {newCharacter?.ToString() ?? "NULL"}");
    }

    static void DebugLoadGame()
    {
        var console = Game.GetConsole();
        console.ConsoleCommand(
            "start batentry?Players=Playable_Batman?Area=OW,OW_A9,OW_A6,OW_A7,OW_A8,OW_R1,OW_R2,OW_E3,OW_E4,OW_A1_Static_LOD,OW_A2,OW_A3_Static_LOD,OW_A4_Static_LOD,OW_A5_Static_LOD,OW_R3,OW_E2_Static_LOD,OW_E6_Static_LOD,OW_E5_Static_LOD,OW_RE1_Static_LOD?Flags=Vertical_Slice,Demo_Riddler_Door_Switch,Map_TriggeredCityStories,Batman_ResonatorCodes,Teleport_Church_To_Museum,Demo_Ryder_Bully,Demo_Courthouse_Lock,Public_Demo?Chapters=1,1b,2,2a,Z1,V1?Start=BeginVS?"
        );
    }

    static void DebugToggleGhost()
    {
        var cheatManager = Game.GetCheatManager();
        cheatManager.ToggleGhost();
    }

    static void DebugAddSplitScreenPlayer()
    {
        var gameViewport = Game.GetGameViewportClient();
        gameViewport.DesiredSplitscreenType = GameViewportClient.ESplitScreenType.eSST_2P_VERTICAL;
        gameViewport.CreatePlayer(1, out _, true);
    }
}

/// <summary>
/// Component that redirects cinematic actor behavior.
/// Automatically attaches to RCinematicCustomActor instances.
/// </summary>
public class CinematicActorComponent : ScriptComponent
{
    // Access the target actor via Owner, cast to the specific type
    RCinematicCustomActor Target => (RCinematicCustomActor)Owner;

    [Redirector(typeof(RCinematicCustomActor), nameof(RCinematicCustomActor.PostBeginPlay))]
    public void CustomPostBeginPlay()
    {
        // Load package with Robin's meshes
        Game.LoadPackage("Playable_Robin_Std_SF");

        // Replace cinematic Batman (head/body)
        if (Target.SkeletalMeshComponent.SkeletalMesh.Name.ToString() == "Batman_Head_Skin")
        {
            var newHeadMesh = Game.FindObject<SkeletalMesh>("Robin.Mesh.Robin_Head_Skin");
            var newBodyMesh = Game.FindObject<SkeletalMesh>("Robin.Mesh.Robin_Staff_V2");
            Target.SkeletalMeshComponent.SetSkeletalMesh(newHeadMesh);
            Target.ExtraSkeletalMeshComponent1.SetSkeletalMesh(newBodyMesh);
            Debug.Log("Using Robin's head/body");
        }

        // Replace cinematic Batman (cape)
        if (Target.SkeletalMeshComponent.SkeletalMesh?.Name.ToString() == "Cape_Mesh")
        {
            var newCapeMesh = Game.FindObject<SkeletalMesh>("Robin.Mesh.Robin_Cape_V2");
            Target.SkeletalMeshComponent.SetSkeletalMesh(newCapeMesh);
            Debug.Log("Using Robin's cape");
        }

        // Calling the base implementation is optional.
        Target.PostBeginPlay();
    }

    [Redirector(typeof(RCinematicCustomActor), nameof(RCinematicCustomActor.BeginAnimControl))]
    public void CustomBeginAnimControl(InterpGroup inInterpGroup)
    {
        Debug.Log($"Hello from BeginAnimControl!");

        // Calling the base implementation is optional.
        Target.BeginAnimControl(inInterpGroup);
    }
}
