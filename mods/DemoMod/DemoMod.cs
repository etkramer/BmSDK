using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;
using BmSDK.Framework;

namespace DemoMod;

public class DemoMod : GameMod
{
    public override void OnInit()
    {
        Debug.Log("OnInit called");

        // Use Joker combat animations on Batman
        // foreach (var pawnPlayerCombat in GameObject.GObjects.OfType<RPawnPlayerCombat>())
        // {
        //     pawnPlayerCombat.AdditionalCombatAnimSet = GameObject.FindObject<AnimSet>(
        //         "Joker_Combat_Anims.Anims.Joker_Combat_Anims"
        //     );

        //     pawnPlayerCombat.OverrideThugCombatAnimSet = GameObject.FindObject<AnimSet>(
        //         "Thug_Anims.JokerSpecific_Anims.Thug_JokerSpecificCombat_Anims"
        //     );

        //     pawnPlayerCombat.AutoStrikeAnimSet = GameObject.FindObject<AnimSet>(
        //         "Joker_Combat_Anims.Anims.Joker_Combat_Anims"
        //     );

        //     pawnPlayerCombat.StunMoveProp = GameObject.FindObject<SkeletalMesh>(
        //         "Game_Pickups.Spraycan.SprayCan_forAnimation"
        //     );
        // }
    }

    public override void OnStart()
    {
        Debug.Log($"Found {GameObject.FindObjects<RCinematicBatman>().Last()}");
    }
}
