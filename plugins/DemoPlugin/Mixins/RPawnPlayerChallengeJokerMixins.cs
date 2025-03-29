using System.Diagnostics;
using BmSDK;
using BmSDK.BmScript;
using BmSDK.Engine;
using BmSDK.Framework;

namespace DemoPlugin.Mixins;

public static class RPawnPlayerChallengeJokerMixins
{
    [Mixin(
        typeof(RPawnPlayerChallengeJoker),
        nameof(RPawnPlayerChallengeJoker.PostBeginPlay),
        MixinOrder.After
    )]
    public static void PostBeginPlayAfter(RPawnPlayerChallengeJoker self)
    {
        Debug.WriteLine($"DemoPlugin mixin: RPawnPlayerChallengeJoker.PostBeginPlay");

        // Load Batman meshes
        var meshClass = SkeletalMesh.StaticClass();
        var batmanBodyMesh = (SkeletalMesh)
            GameObject.DynamicLoadObject("Batman_V2.Mesh.Batman_skin", meshClass);
        var batmanHeadMesh = (SkeletalMesh)
            GameObject.DynamicLoadObject("Batman_V2.Mesh.Batman_Head_Skin", meshClass);

        // Get existing components
        var bodyComponent = self.Components.OfType<SkeletalMeshComponent>().ElementAt(0);
        var headComponent = self.Components.OfType<SkeletalMeshComponent>().ElementAt(1);

        // Replace body/head meshes
        bodyComponent.SetPhysicsAsset(null, true);
        bodyComponent.SetSkeletalMesh(batmanBodyMesh);
        headComponent.SetSkeletalMesh(batmanHeadMesh);
        headComponent.SetMaterial(0, batmanHeadMesh.Materials[0]);
        headComponent.SetMaterial(1, batmanHeadMesh.Materials[1]);
    }
}
