using BmSDK;

[Script]
public class LoadHelperScript : Script
{
    public override void OnInit()
    {
        // Load packages containing classes we'll want at generation time
        Game.LoadPackage("Playable_Batman_SF");
        Game.LoadPackage("Playable_Robin_SF");
        Game.LoadPackage("FunFair");
        Game.LoadPackage("Under_B6_Ch7");
        Game.LoadPackage("Under_S3_Ch4");
        Game.LoadPackage("Under_S2_Ch8");
        Game.LoadPackage("BaneSS_B1");
        Game.LoadPackage("GCPD_A1_Ch5");
        Game.LoadPackage("Church_B1_Ch3456789");
    }
}
