using BmSDK.BmScript;

[Script]
public class MinimalScript : Script
{
    public override void OnEnterGame()
    {
        var playerPawn = Game.GetPlayerPawn(0);
        Debug.Log($"Player is at {playerPawn.Location}");
    }

    public override void OnEnterMenu()
    {
        // Enable info display
        Game.GetGameViewportClient().bShowSessionDebug = true;
    }
}