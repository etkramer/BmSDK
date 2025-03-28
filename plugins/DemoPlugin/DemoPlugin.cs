using System.Diagnostics;
using BmSDK;
using BmSDK.BmScript;
using BmSDK.Engine;
using BmSDK.Framework;

namespace DemoPlugin;

public class DemoPlugin : ManagedPlugin
{
    public override void OnLoad()
    {
        // Test script functions
        Debug.WriteLine($"1 + 2 = {GameObject.Add_IntInt(1, 2)}");

        // Test StaticClass()
        Debug.WriteLine($"Class::StaticClass(): {Class.StaticClass()}");
        Debug.WriteLine($"Actor::StaticClass(): {Actor.StaticClass()}");

        // Test ConstructObject()
        var newObj = new MacroReachSpec(null, "SomeMacroReachSpec");
        Debug.WriteLine($"New object: {newObj}");

        base.OnLoad();
    }

    public override void OnGameStart()
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

        // TODO: Prop offsets are still wrong (ActorComponent has size 73 at runtime, but PrimitiveComponent begins at 76)
        // TODO: Prop offsets are still wrong (PrimitiveComponent has size 420 at runtime, but MeshComponent begins at 432)
        // TODO: Prop offsets are still wrong (MeshComponent has size 432 at runtime, but SkeletalMeshComponent begins at 444)
        Debug.WriteLine($"Component: {Component.StaticClass().PropertiesSize}");
        Debug.WriteLine($"ActorComponent: {ActorComponent.StaticClass().PropertiesSize}");
        Debug.WriteLine($"PrimitiveComponent: {PrimitiveComponent.StaticClass().PropertiesSize}");
        Debug.WriteLine($"MeshComponent: {MeshComponent.StaticClass().PropertiesSize}");
        Debug.WriteLine(
            $"SkeletalMeshComponent: {SkeletalMeshComponent.StaticClass().PropertiesSize}"
        );

        base.OnGameStart();
    }
}
