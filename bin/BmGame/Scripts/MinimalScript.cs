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
            console.ConsoleCommand("start batentry?Area=Orphan_A1?Players=Playable_Batman");
        }
        else if (key == Keys.O)
        {
            var playerPawn = (RPawnPlayerBm)Game.GetPlayerPawn(0);

            // Test native functions
            var newLocation = playerPawn.Location + new Vector3(0, 0, 200);
            playerPawn.SetLocation(newLocation);
        }
    }
}
