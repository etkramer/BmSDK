using BmSDK;
using BmSDK.BmScript;
using BmSDK.Engine;

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

        playerPawn.SetInXrayMode(true, false);
        playerPawn.Set1stPerson(true);

        // playerPawn.CapeComponent.SetHidden(true);
        // playerPawn.CapeSkeletalMesh.SetHidden(true);
    }
}
