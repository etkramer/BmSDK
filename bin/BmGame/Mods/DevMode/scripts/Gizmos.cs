using System.Numerics;
using BmSDK;
using BmSDK.Engine;

namespace DevMode;

public static class Gizmos
{
    private const float NearPlane = 1f;

    private static Vector2 _displaySize;
    private static ImDrawListPtr _drawList;
    private static Vector3 _cameraPos;
    private static Vector3 _cameraFwd;
    private static Vector3 _cameraRight;
    private static Vector3 _cameraUp;
    private static float _tanHalfFov;
    private static float _aspectRatio;

    public static void Begin(FreeCamera camera, Vector2 displaySize)
    {
        _displaySize = displaySize;
        _drawList = ImGui.GetBackgroundDrawList();
        _cameraPos = camera.Position;
        _cameraFwd = camera.Forward;
        _cameraRight = Vector3.Normalize(Vector3.Cross(Vector3.UnitZ, _cameraFwd));
        _cameraUp = Vector3.Cross(_cameraFwd, _cameraRight);
        _aspectRatio = displaySize.X / displaySize.Y;
        _tanHalfFov = MathF.Tan(camera.Fov * MathF.PI / 360f);
    }

    public static void DrawLine(Vector3 from, Vector3 to, uint color, float thickness = 2f)
    {
        var depthFrom = Vector3.Dot(from - _cameraPos, _cameraFwd);
        var depthTo = Vector3.Dot(to - _cameraPos, _cameraFwd);

        if (depthFrom <= NearPlane && depthTo <= NearPlane)
        {
            return;
        }

        if (depthFrom <= NearPlane)
        {
            from = Vector3.Lerp(from, to, (NearPlane - depthFrom) / (depthTo - depthFrom));
        }
        else if (depthTo <= NearPlane)
        {
            to = Vector3.Lerp(to, from, (NearPlane - depthTo) / (depthFrom - depthTo));
        }

        if (WorldToScreen(from, out var a) && WorldToScreen(to, out var b))
        {
            _drawList.AddLine(a, b, color, thickness);
        }
    }

    public static void DrawWireBox(Vector3 center, Vector3 localHalfExtents, Rotator rotation, uint color, float thickness = 2f)
    {
        RotationBasis(rotation, out var fwd, out var right, out var up);

        Span<Vector3> c = stackalloc Vector3[8];
        for (var i = 0; i < 8; i++)
        {
            var lx = (i & 1) != 0 ? localHalfExtents.X : -localHalfExtents.X;
            var ly = (i & 2) != 0 ? localHalfExtents.Y : -localHalfExtents.Y;
            var lz = (i & 4) != 0 ? localHalfExtents.Z : -localHalfExtents.Z;
            c[i] = center + fwd * lx + right * ly + up * lz;
        }

        // Bottom face
        DrawLine(c[0], c[1], color, thickness);
        DrawLine(c[1], c[3], color, thickness);
        DrawLine(c[3], c[2], color, thickness);
        DrawLine(c[2], c[0], color, thickness);

        // Top face
        DrawLine(c[4], c[5], color, thickness);
        DrawLine(c[5], c[7], color, thickness);
        DrawLine(c[7], c[6], color, thickness);
        DrawLine(c[6], c[4], color, thickness);

        // Vertical edges
        DrawLine(c[0], c[4], color, thickness);
        DrawLine(c[1], c[5], color, thickness);
        DrawLine(c[2], c[6], color, thickness);
        DrawLine(c[3], c[7], color, thickness);
    }

    public static (Vector3 Center, Vector3 Extents) ComputeLocalBounds(Actor actor)
    {
        RotationBasis(actor.Rotation, out var fwd, out var right, out var up);

        var localMin = new Vector3(float.MaxValue);
        var localMax = new Vector3(float.MinValue);
        var any = false;

        foreach (var component in actor.AllComponents)
        {
            if (component is not MeshComponent mesh)
            {
                continue;
            }

            var bounds = mesh.Bounds;
            var extent = bounds.BoxExtent;
            if (extent == Vector3.Zero)
            {
                continue;
            }

            any = true;
            var origin = bounds.Origin;

            for (var i = 0; i < 8; i++)
            {
                var corner = origin + new Vector3(
                    (i & 1) != 0 ? extent.X : -extent.X,
                    (i & 2) != 0 ? extent.Y : -extent.Y,
                    (i & 4) != 0 ? extent.Z : -extent.Z
                );

                var offset = corner - actor.Location;
                var local = new Vector3(
                    Vector3.Dot(offset, fwd),
                    Vector3.Dot(offset, right),
                    Vector3.Dot(offset, up)
                );

                localMin = Vector3.Min(localMin, local);
                localMax = Vector3.Max(localMax, local);
            }
        }

        if (!any)
        {
            actor.GetComponentsBoundingBox(out var box);
            var boxOrigin = (box.Min + box.Max) / 2f;
            var boxExtent = (box.Max - box.Min) / 2f;

            for (var i = 0; i < 8; i++)
            {
                var corner = boxOrigin + new Vector3(
                    (i & 1) != 0 ? boxExtent.X : -boxExtent.X,
                    (i & 2) != 0 ? boxExtent.Y : -boxExtent.Y,
                    (i & 4) != 0 ? boxExtent.Z : -boxExtent.Z
                );

                var offset = corner - actor.Location;
                var local = new Vector3(
                    Vector3.Dot(offset, fwd),
                    Vector3.Dot(offset, right),
                    Vector3.Dot(offset, up)
                );

                localMin = Vector3.Min(localMin, local);
                localMax = Vector3.Max(localMax, local);
            }
        }

        var localCenter = (localMin + localMax) / 2f;
        var localExtents = (localMax - localMin) / 2f;
        var worldCenter = actor.Location + fwd * localCenter.X + right * localCenter.Y + up * localCenter.Z;

        return (worldCenter, localExtents);
    }

    private static bool WorldToScreen(Vector3 worldPos, out Vector2 screenPos)
    {
        var toPoint = worldPos - _cameraPos;

        var depth = Vector3.Dot(toPoint, _cameraFwd);
        if (depth <= 0.001f)
        {
            screenPos = default;
            return false;
        }

        var ndcX = Vector3.Dot(toPoint, _cameraRight) / (depth * _tanHalfFov);
        var ndcY = -Vector3.Dot(toPoint, _cameraUp) * _aspectRatio / (depth * _tanHalfFov);

        screenPos = new Vector2(
            (ndcX / 2f + 0.5f) * _displaySize.X,
            (ndcY / 2f + 0.5f) * _displaySize.Y
        );

        return true;
    }

    private static void RotationBasis(Rotator rotation, out Vector3 forward, out Vector3 right, out Vector3 up)
    {
        var cp = MathF.Cos(rotation.Pitch * MathF.PI / 180f);
        var sp = MathF.Sin(rotation.Pitch * MathF.PI / 180f);
        var cy = MathF.Cos(rotation.Yaw * MathF.PI / 180f);
        var sy = MathF.Sin(rotation.Yaw * MathF.PI / 180f);
        var cr = MathF.Cos(rotation.Roll * MathF.PI / 180f);
        var sr = MathF.Sin(rotation.Roll * MathF.PI / 180f);

        forward = new Vector3(cp * cy, cp * sy, sp);
        right = new Vector3(sr * sp * cy - cr * sy, sr * sp * sy + cr * cy, -sr * cp);
        up = new Vector3(-(cr * sp * cy + sr * sy), cy * sr - cr * sp * sy, cr * cp);
    }
}
