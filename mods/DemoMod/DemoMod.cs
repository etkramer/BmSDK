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
    }

    public override void OnEnterMenu()
    {
        var console = GameObject.FindObjects<Console>().Last();
        Debug.Log($"Found {console}");

        Task.Delay(1000)
            .ContinueWith(_ =>
            {
                Debug.Log("Entering game");
                console.ConsoleCommand(
                    "start batentry?Players=Playable_Batman?Area=Church?Flags=Vertical_Slice?Chapters=1,2?unlockall"
                );
            });
    }

    public override void OnEnterGame()
    {
        var playerPawns = GameObject
            .FindObjects<RPawnPlayer>()
            .Where(obj => !obj.Name.ToString().StartsWith("Default__"));

        Debug.Log($"Found {playerPawns.Count()} loaded player pawns");
    }
}
