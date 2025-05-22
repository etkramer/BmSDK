using BmSDK;
using BmSDK.BmGame;
using BmSDK.Engine;
using BmSDK.Framework;
using Console = BmSDK.Engine.Console;

namespace LoadHelperMod;

public class LoadHelperMod : GameMod
{
    public override void OnInit()
    {
        // Load packages containing classes we'll want at generation time
        GameObject.LoadPackage("Playable_Batman_SF");
    }
}
