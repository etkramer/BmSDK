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
        foreach (var pawnPlayerCombat in GameObject.GObjects.OfType<RPawnPlayerCombat>())
        {
            pawnPlayerCombat.AdditionalCombatAnimSet =
                GameObject.FindObject(
                    "Joker_Combat_Anims.Anims.Joker_Combat_Anims",
                    AnimSet.StaticClass()
                ) as AnimSet;

            pawnPlayerCombat.OverrideThugCombatAnimSet =
                GameObject.FindObject(
                    "Thug_Anims.JokerSpecific_Anims.Thug_JokerSpecificCombat_Anims",
                    AnimSet.StaticClass()
                ) as AnimSet;

            pawnPlayerCombat.StunMoveProp =
                GameObject.FindObject(
                    "Game_Pickups.Spraycan.SprayCan_forAnimation",
                    SkeletalMesh.StaticClass()
                ) as SkeletalMesh;

            pawnPlayerCombat.AutoStrikeAnimSet =
                GameObject.FindObject(
                    "Joker_Combat_Anims.Anims.Joker_Combat_Anims",
                    AnimSet.StaticClass()
                ) as AnimSet;
        }
    }

    public override void OnStart()
    {
        Debug.Log($"Found {GameObject.FindObjects<RCinematicBatman>().Last().GetFullName()}");
    }
}
