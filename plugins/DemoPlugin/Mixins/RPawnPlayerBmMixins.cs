using System.Diagnostics;
using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;
using BmSDK.Framework;

namespace DemoPlugin.Mixins;

public static class RPawnPlayerBmMixins
{
    [Mixin(typeof(RPawnPlayerBm), nameof(RPawnPlayerBm.EyeMaterialUpdated))]
    public static void PostBeginPlayBefore(RPawnPlayerBm self)
    {
        Debug.WriteLine($"Mixin: RPawnPlayerBm.PostBeginPlay on {self}");

        // Load Joker meshes
        var meshClass = SkeletalMesh.StaticClass();
        var jokerBodyMesh = (SkeletalMesh)
            GameObject.DynamicLoadObject("Joker.Mesh.Combat_joker", meshClass);
        var jokerHeadMesh = (SkeletalMesh)
            GameObject.DynamicLoadObject("Joker.Mesh.Combat_joker_head", meshClass);

        // Get existing components
        var bodyComponent = self.Components.OfType<SkeletalMeshComponent>().ElementAt(0);
        var headComponent = self.Components.OfType<SkeletalMeshComponent>().ElementAt(1);
        var capeComponent = self.Components.OfType<RCapeComponent>().Last();

        // Hide cape component
        self.DetachComponent(capeComponent);

        // Replace body mesh
        bodyComponent.SetSkeletalMesh(jokerBodyMesh);
        bodyComponent.SetMaterial(0, jokerBodyMesh.Materials[0]);

        // Replace head mesh
        headComponent.SetSkeletalMesh(jokerHeadMesh);
        headComponent.SetMaterial(0, jokerHeadMesh.Materials[0]);
        headComponent.SetMaterial(1, jokerHeadMesh.Materials[1]);
    }
}
