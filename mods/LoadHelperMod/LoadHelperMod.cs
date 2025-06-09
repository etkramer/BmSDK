using BmSDK;

namespace LoadHelperMod;

public class LoadHelperMod : GameMod
{
    public override void OnInit()
    {
        // Load packages containing classes we'll want at generation time
        UObject.LoadPackage("Playable_Batman_SF");
        UObject.LoadPackage("Playable_Robin_SF");
        UObject.LoadPackage("FunFair");
        UObject.LoadPackage("Under_B6_Ch7");
        UObject.LoadPackage("Under_S3_Ch4");
        UObject.LoadPackage("Under_S2_Ch8");
        UObject.LoadPackage("BaneSS_B1");
        UObject.LoadPackage("GCPD_A1_Ch5");
        UObject.LoadPackage("Church_B1_Ch3456789");
    }
}
