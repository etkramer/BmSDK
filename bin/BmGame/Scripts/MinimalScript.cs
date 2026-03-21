using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;
using System.Numerics;

[Script]
public class MinimalScript : Script
{
    public override void Main()
    {
        Debug.Log("Hello from MinimalScript!");

        var engine = Game.GetEngine();
        Debug.Log($"Found {engine.Name}");

        var gameViewport = engine.GameViewport;
        Debug.Log($"Found {gameViewport.Name}");

        var player = gameViewport.FindPlayerByControllerId(0);
        Debug.Log($"Found {player.Name}");

        // Probably not assigned in Main()
        var controller = player.Actor;
        Debug.Log($"Found {controller?.Name ?? "null"}");
    }

    public override void OnEnterGame()
    {
        var playerPawn = (RPawnPlayerBm)Game.GetPlayerPawn(0);

        Debug.Log($"Player is at {playerPawn.Location}");
    }

    public override void OnEnterMenu()
    {
        // Enable info display
        Game.GetGameViewportClient().bShowSessionDebug = true;
    }

    public override void OnKeyDown(Keys key)
    {
        if (key == Keys.Enter)
        {
            // Prevent corrupting current save slot
            var saveMan = Game.GetGameRI().SaveGameManager;
            saveMan.SetActiveStorySlotID(RSaveGameManager.StorySlots.StorySlot_Temp);

            // Enter world
            var console = Game.GetConsole();
            console.ConsoleCommand("start batentry?Players=Playable_Batman?Area=CityZ_17,CityX_02,CityX_03,CityZ_13,CityZ_14,CityZ_16,CityZ_18,CityZ_T17?NoFadeOut?Flags=Batman_GlideBoost,Debug_Freeroam,Debug_Freeroam_Population,IsFreeRoam,Environmental_Analysis_Unlocked,OrganScannedInNormalGame,Map_WaypointEnabled,CityX_06_Penguin_Cache_Accessible?Chapters=0,F1,S0,K1,U1?Start=CityZ_Stage_1?PlayMusic");
        }
        else if (key == Keys.O)
        {
            Game.LoadPackage("Film");
            Game.LoadPackage("Film_A1_Ch6");

            var playerPawn = Game.GetPlayerPawn(0);
            var populationManager = Game.GetPopulationManager();

            // Test native functions
            var newLocation = playerPawn.Location + new Vector3(0, 0, 200);
            playerPawn.SetLocation(newLocation);

            // Spawn a thug
            var spawnLocation = playerPawn.Location + new Vector3(200, 0, 0);
            var thugDefine = Game.FindObject<RCharacterDefine>("ThugDefines.Harley.HarleyThug1");
            var thugPawn = populationManager.SpawnPawn(RPawnVillainThug.StaticClass(), thugDefine, RCharacter_Thug.StaticClass(), spawnLocation);

            Debug.Log(thugPawn);
        }
    }
}
