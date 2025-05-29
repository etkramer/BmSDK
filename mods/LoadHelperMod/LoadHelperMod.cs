using BmSDK;

namespace LoadHelperMod;

public class LoadHelperMod : GameMod
{
    public override void OnInit()
    {
        // Load packages containing classes we'll want at generation time
        UObject.LoadPackage("Playable_Batman_SF");
        UObject.LoadPackage("Playable_Robin_SF");
    }
}
