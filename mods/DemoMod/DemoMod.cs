using BmSDK;
using BmSDK.BmScript;
using BmSDK.Framework;

namespace DemoMod;

public class DemoMod : GameMod
{
    public override void OnInit()
    {
        Debug.Log("OnInit called");

        // Test script functions
        // Debug.WriteLine($"abs(-2) = {GameObject.Abs(-2)}");
    }

    public override void OnStart()
    {
        Debug.Log($"Found {GameObject.GObjects.OfType<RCinematicBatman>().Last().GetFullName()}");
    }
}
