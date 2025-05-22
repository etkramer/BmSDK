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
        Debug.Log("OnInit called");

        // Boost snow intensity
        var defaultRainComponent = GameObject.FindObjects<RRainComponent>().First();
        defaultRainComponent.ParticleCount *= 5;
    }

    public override void OnStart()
    {
        var console = GameObject.FindObjects<Console>().Last();
        Debug.Log($"Found {console}");

        Task.Delay(1000)
            .ContinueWith(_ =>
            {
                Debug.Log("Entering game");
                console.ConsoleCommand(
                    "start batentry?Players=Playable_Batman?Area=OW,OW_A9,OW_A6,OW_A7,OW_A8,OW_R1,OW_R2,OW_E3,OW_E4,OW_A1_Static_LOD,OW_A2,OW_A3_Static_LOD,OW_A4_Static_LOD,OW_A5_Static_LOD,OW_R3,OW_E2_Static_LOD,OW_E6_Static_LOD,OW_E5_Static_LOD,OW_RE1_Static_LOD?Flags=Vertical_Slice,Demo_Riddler_Door_Switch,Map_TriggeredCityStories,Batman_ResonatorCodes,Teleport_Church_To_Museum,Demo_Ryder_Bully,Demo_Courthouse_Lock,Public_Demo?Chapters=1,1b,Z1,V1?Start=BeginVS?"
                );
            });
    }
}
