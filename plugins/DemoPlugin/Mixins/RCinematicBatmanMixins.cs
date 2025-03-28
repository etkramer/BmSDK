using System.Diagnostics;
using BmSDK.BmScript;
using BmSDK.Engine;
using BmSDK.Framework;

namespace DemoPlugin.Mixins;

public static class RCinematicBatmanMixins
{
    [Mixin(typeof(RCinematicBatman), nameof(RCinematicBatman.PostBeginPlay), MixinOrder.Before)]
    public static void PostBeginPlayBefore(RCinematicBatman self)
    {
        Debug.WriteLine("DemoPlugin mixin: RCinematicBatman.PostBeginPlay");

        // Hide body mesh
        var meshComponent = self.Components.OfType<SkeletalMeshComponent>().ElementAt(0);
        meshComponent.SetHidden(true);
    }
}
