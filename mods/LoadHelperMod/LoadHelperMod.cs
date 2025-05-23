using BmSDK;
using BmSDK.Framework;

namespace LoadHelperMod;

public class LoadHelperMod : GameMod
{
    public override void OnInit()
    {
        // Load packages containing classes we'll want at generation time
        GameObject.LoadPackage("Playable_Batman_SF");
        GameObject.LoadPackage("Playable_Robin_SF");
    }
}
