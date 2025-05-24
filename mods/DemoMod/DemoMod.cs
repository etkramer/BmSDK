using BmSDK;
using BmSDK.BmGame;
using BmSDK.Engine;
using BmSDK.Framework;
using Console = BmSDK.Engine.Console;

namespace DemoMod;

public class DemoMod : GameMod
{
    public override void OnInit()
    {
        // Boost snow intensity
        var defaultRainComponent = GameObject.FindObjects<RRainComponent>().First();
        defaultRainComponent.ParticleCount *= 5;

        Debug.Log($"abs(-5) = {GameObject.Abs(-5)}");
    }

    public override void OnEnterGame()
    {
        var playerPawns = GameObject
            .FindObjects<RPawnPlayer>()
            .Where(obj => !obj.Name.ToString().StartsWith("Default__"));

        Debug.Log($"Found {playerPawns.Count()} loaded player pawns");
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
    }

    private static void DebugLoadGame()
    {
        var console = GameObject.FindObjects<Console>().Last();
        console.ConsoleCommand(
            "start batentry?Players=Playable_Batman?Area=Church?Flags=Vertical_Slice?Chapters=1,2?unlockall"
        );
    }

    private static void DebugAddSplitScreenPlayer()
    {
        var gameViewport = GameObject.FindObjects<GameViewportClient>().Last();
        gameViewport.DesiredSplitscreenType = GameViewportClient.ESplitScreenType.eSST_2P_VERTICAL;
        gameViewport.CreatePlayer(1, "fun", true);

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
