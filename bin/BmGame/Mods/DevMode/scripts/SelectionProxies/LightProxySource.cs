using System.Numerics;
using BmSDK;
using BmSDK.Engine;

namespace DevMode;

public class LightProxySource : SelectionProxySource
{
    private const float CubeHalfExtent = 16f;

    public override void Draw()
    {
        foreach (var light in Game.FindObjects<Light>())
        {
            Gizmos.DrawWireBox(
                light.Location,
                new Vector3(CubeHalfExtent),
                default,
                GetColor(light)
            );
        }
    }

    public override bool TryPick(Vector3 origin, Vector3 direction, out float t, out GameObject target)
    {
        t = float.PositiveInfinity;
        target = null!;

        foreach (var light in Game.FindObjects<Light>())
        {
            var min = light.Location - new Vector3(CubeHalfExtent);
            var max = light.Location + new Vector3(CubeHalfExtent);

            if (RayVsAabb(origin, direction, min, max, out var hitT) && hitT < t)
            {
                t = hitT;
                target = light;
            }
        }

        return target is not null;
    }

    private static uint GetColor(Light light)
    {
        var component = light.LightComponent;
        if (component is null)
        {
            return 0xFF00FFFFu;
        }

        var c = component.LightColor;
        return (0xFFu << 24) | ((uint)c.B << 16) | ((uint)c.G << 8) | c.R;
    }
}
