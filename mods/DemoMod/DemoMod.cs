using System.Diagnostics;
using BmSDK;
using BmSDK.Framework;

namespace DemoMod;

public class DemoMod : GameMod
{
    public override void OnInit()
    {
        Debug.WriteLine("DemoMod: OnInit()");

        // Test script functions
        // Debug.WriteLine($"abs(-2) = {GameObject.Abs(-2)}");
    }

    public override void OnStart()
    {
        Debug.WriteLine("DemoMod: OnStart()");
    }
}
