using System.Numerics;
using BmSDK;

namespace DevMode;

public abstract class SelectionProxySource
{
    public abstract void Draw();

    public abstract bool TryPick(Vector3 origin, Vector3 direction, out float t, out GameObject target);

    protected static bool RayVsAabb(Vector3 origin, Vector3 direction, Vector3 min, Vector3 max, out float t)
    {
        var tMin = float.NegativeInfinity;
        var tMax = float.PositiveInfinity;

        for (var axis = 0; axis < 3; axis++)
        {
            var o = axis == 0 ? origin.X : axis == 1 ? origin.Y : origin.Z;
            var d = axis == 0 ? direction.X : axis == 1 ? direction.Y : direction.Z;
            var mn = axis == 0 ? min.X : axis == 1 ? min.Y : min.Z;
            var mx = axis == 0 ? max.X : axis == 1 ? max.Y : max.Z;

            if (MathF.Abs(d) < 1e-8f)
            {
                if (o < mn || o > mx)
                {
                    t = 0f;
                    return false;
                }

                continue;
            }

            var t1 = (mn - o) / d;
            var t2 = (mx - o) / d;
            if (t1 > t2)
            {
                (t1, t2) = (t2, t1);
            }

            tMin = MathF.Max(tMin, t1);
            tMax = MathF.Min(tMax, t2);

            if (tMin > tMax)
            {
                t = 0f;
                return false;
            }
        }

        t = tMin >= 0f ? tMin : tMax;
        return t >= 0f;
    }
}
