using System.Diagnostics;
using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;
using BmSDK.Framework;
using DemoPlugin.Mixins;

namespace DemoPlugin;

public class DemoPlugin : ManagedPlugin
{
    public override void OnInit()
    {
        Debug.WriteLine("DemoPlugin: OnInit()");

        // Setup mixins
        MixinManager.RegisterMixins(typeof(RCinematicBatmanMixins));
        MixinManager.RegisterMixins(typeof(RPawnPlayerBmMixins));
        MixinManager.RegisterMixins(typeof(RPawnPlayerChallengeJokerMixins));

        // Test script functions
        Debug.WriteLine($"1 + 2 = {GameObject.Add_IntInt(1, 2)}");
    }

    public override void OnStart()
    {
        Debug.WriteLine("DemoPlugin: OnStart()");
    }
}
