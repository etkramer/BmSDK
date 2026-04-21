using System.Numerics;
using BmSDK;

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
        _drawList = ImGui.GetForegroundDrawList();
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

    public static Vector3 RecoverLocalExtents(Vector3 worldHalfExtents, Rotator rotation)
    {
        RotationBasis(rotation, out var fwd, out var right, out var up);

        // The world-space AABB half-extents relate to local extents by:
        //   M * local = world,  where M[i][j] = |basis_j[i]|
        float m00 = MathF.Abs(fwd.X), m01 = MathF.Abs(right.X), m02 = MathF.Abs(up.X);
        float m10 = MathF.Abs(fwd.Y), m11 = MathF.Abs(right.Y), m12 = MathF.Abs(up.Y);
        float m20 = MathF.Abs(fwd.Z), m21 = MathF.Abs(right.Z), m22 = MathF.Abs(up.Z);

        var det = m00 * (m11 * m22 - m12 * m21)
                  - m01 * (m10 * m22 - m12 * m20)
                  + m02 * (m10 * m21 - m11 * m20);

        if (MathF.Abs(det) < 0.001f)
        {
            return worldHalfExtents;
        }

        var invDet = 1f / det;
        var w = worldHalfExtents;

        return new Vector3(
            MathF.Abs(invDet * (w.X * (m11 * m22 - m12 * m21) - m01 * (w.Y * m22 - m12 * w.Z) + m02 * (w.Y * m21 - m11 * w.Z))),
            MathF.Abs(invDet * (m00 * (w.Y * m22 - m12 * w.Z) - w.X * (m10 * m22 - m12 * m20) + m02 * (m10 * w.Z - w.Y * m20))),
            MathF.Abs(invDet * (m00 * (m11 * w.Z - w.Y * m21) - m01 * (m10 * w.Z - w.Y * m20) + w.X * (m10 * m21 - m11 * m20)))
        );
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
