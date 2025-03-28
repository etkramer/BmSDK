using System.Diagnostics;
using BmSDK;
using BmSDK.BmScript;
using BmSDK.Engine;
using BmSDK.Framework;

namespace DemoPlugin;

public class DemoPlugin : ManagedPlugin
{
    public override void OnInit()
    {
        // Test script functions
        Debug.WriteLine($"1 + 2 = {GameObject.Add_IntInt(1, 2)}");

        // Test StaticClass()
        Debug.WriteLine($"Class::StaticClass(): {Class.StaticClass()}");
        Debug.WriteLine($"Actor::StaticClass(): {Actor.StaticClass()}");

        // Test ConstructObject()
        var newObj = new MacroReachSpec(null, "SomeMacroReachSpec");
        Debug.WriteLine($"New object: {newObj}");
    }

    public override void OnStart()
    {
        // Test dynamic object loading
        var jokerMesh = GameObject.DynamicLoadObject(
            "Joker.Mesh.Combat_joker",
            SkeletalMesh.StaticClass()
        );
        Debug.WriteLine($"Loaded mesh {jokerMesh}");

        // Test FindObjects(), actor properties
        var meshActor = GameObject.FindObjects<RCinematicBatman>().Last();
        var meshComponent = meshActor.Components.OfType<SkeletalMeshComponent>().ElementAt(0);
        Debug.WriteLine($"Found actor {meshActor}");
        Debug.WriteLine($"Found component {meshComponent}");

        // Test object methods
        meshComponent.SetHidden(true);
    }
}
